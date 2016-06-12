using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Blacklite.Shared.Reflection;

namespace Blacklite.Domain.Steps
{
    /// <summary>
    /// Interface that describes a step.
    /// This doesn't expose the step, as each step has it's own execute method that varies.
    /// </summary>
    public interface IStepDescriptor<TReturn>
    {
        bool CanRun(Type type);
        bool CanExecute(object instance);
        TReturn Execute(IServiceProvider serviceProvider, object instance);
    }

    /// <summary>
    /// The underlying implementation, this also has many other properties that are used
    ///    in the Step Provider to build an appropriate list of steps.
    /// </summary>
    class StepDescriptor<TReturn> : IStepDescriptor<TReturn>
    {
        /// <summary>
        ///  The execute method
        /// </summary>
        public Func<IServiceProvider, object, TReturn> ExecuteFunc { get; private set; }

        /// <summary>
        /// The underlying step
        /// </summary>
        public IStep Step { get; private set; }

        /// <summary>
        /// The step type, used to get the Name
        /// </summary>
        private Type _stepType;
        private Type StepType
        {
            get
            {
                if (_stepType == null)
                    _stepType = Step.GetType();
                return _stepType;
            }
        }

        /// <summary>
        /// The name of the step, calls through to the type.
        /// </summary>
        public string Name => StepType.FullName;

        /// <summary>
        /// Gets the stages this step is a part of.
        ///
        /// Stages are a special snow flake and define two (and maybe more in the future) different sets of phases.
        ///
        /// A process step can span stages
        /// </summary>
        public IEnumerable<string> Stages { get; private set; }

        /// <summary>
        /// Gets the phases this step is a part of.
        ///
        /// A process step can span many phases
        /// </summary>
        public IEnumerable<IStepPhase> Phases { get; private set; }

        /// <summary>
        /// If this process step has been overriden, it will be shown here.
        ///
        /// The other process step generally runs if it has been override, unless it's Can Execute method says it can't.
        /// </summary>
        public IEnumerable<StepDescriptor<TReturn>> Overrides { get; private set; }

        /// <summary>
        /// These are the process steps that have to run before this process step
        /// </summary>
        private IEnumerable<StepDescriptor<TReturn>> _before;

        /// <summary>
        /// These are the process steps that have to run after the process step
        /// </summary>
        private IEnumerable<StepDescriptor<TReturn>> _after;

        /// <summary>
        /// These are are all the process steps that have to run after the process, this
        ///     takes into account any process step that include us in their before section.
        ///
        /// This data is used by TopograhicalSort to produce an appropriatly sorted list.
        /// </summary>
        public IEnumerable<StepDescriptor<TReturn>> DependsOn { get; private set; }

        public void Fixup(IEnumerable<StepDescriptor<TReturn>> descriptors)
        {
            // Fixup, as they may have some null values
            Overrides = descriptors.Join(Overrides, x => x, x => x, (d, x) => d);
            _before = descriptors.Join(_before, x => x, x => x, (d, x) => d);
            _after = descriptors.Join(_after, x => x, x => x, (d, x) => d);

            DependsOn = _after.Union(descriptors.Where(x => x._before.Contains(this))).ToArray();
        }

        public static StepDescriptor<TReturn> Create<TStep>(IEnumerable<TStep> steps, ICollection<StepDescriptor<TReturn>> overrideSteps, IStep step)
            where TStep : IStep
        {
            var phases = (step as IPhasedStep)?.Phases ?? Enumerable.Empty<IStepPhase>();

            return new StepDescriptor<TReturn>()
            {
                Step = step,
                Phases = phases,
                Stages = phases.Select(x => x.Stage).Distinct(),
                Overrides = GetStepOverrides(steps, overrideSteps, step),
                _before = GetRunsBefore(steps, overrideSteps, step),
                _after = GetRunsAfter(steps, overrideSteps, step),
                ExecuteFunc = GetExecuteAction(step)
            };
        }

        private static Func<IServiceProvider, object, TReturn> GetExecuteAction([NotNull] IStep step)
        {
            var typeInfo = step.GetType().GetTypeInfo();

            return typeInfo.CreateInjectableMethod(nameof(Execute))
                .ConfigureInstanceParameter(instance => parameterInfo => parameterInfo.ParameterType.GetTypeInfo().IsAssignableFrom(instance.GetType().GetTypeInfo()))
                .ReturnType(typeof(void), typeof(TReturn))
                .CreateFunc<object, TReturn>(step);
        }

        private static IEnumerable<StepDescriptor<TReturn>> GetStepOverrides<TStep>(IEnumerable<TStep> steps, ICollection<StepDescriptor<TReturn>> overrideSteps, IStep step)
            where TStep : IStep
        {
            // Find all steps that subclass us.
            // This will add multiple steps to the list if there are mutliple children / grandchildren, this should still not be an issue.
            var stepType = step.GetType();
            foreach (var overrideStep in steps
                .Where(s => s.GetType().GetTypeInfo().IsSubclassOf(stepType)))
            {
                var descriptor = overrideSteps.SingleOrDefault(x => x.Step == (IStep)overrideStep);
                if (descriptor == null)
                {
                    descriptor = Create<TStep>(steps, overrideSteps, step);
                    overrideSteps.Add(descriptor);
                }
                yield return descriptor;
            }
        }

        private static IEnumerable<StepDescriptor<TReturn>> GetRunsAfter<TStep>(IEnumerable<TStep> steps, ICollection<StepDescriptor<TReturn>> overrideSteps, IStep step)
            where TStep : IStep
        {
            // Find all steps that run after and create their descriptor if not created.
            foreach (var order in step.GetType()
                .GetTypeInfo()
                .GetCustomAttributes<AfterStepAttribute>())
            {
                var descriptor = overrideSteps.SingleOrDefault(x => x.StepType == order.Step);
                var otherStep = steps.SingleOrDefault(x => x.GetType() == order.Step);
                if (descriptor == null && otherStep != null)
                {
                    descriptor = Create(steps, overrideSteps, otherStep);
                    overrideSteps.Add(descriptor);
                }

                yield return descriptor;
            }
        }

        private static IEnumerable<StepDescriptor<TReturn>> GetRunsBefore<TStep>(IEnumerable<TStep> steps, ICollection<StepDescriptor<TReturn>> overrideSteps, IStep step)
            where TStep : IStep
        {
            // Find all steps that run before and create their descriptor if not created.
            foreach (var order in step.GetType()
                .GetTypeInfo()
                .GetCustomAttributes<BeforeStepAttribute>())
            {
                var descriptor = overrideSteps.SingleOrDefault(x => x.StepType == order.Step);
                var otherStep = steps.SingleOrDefault(x => x.GetType() == order.Step);
                if (descriptor == null && otherStep != null)
                {
                    descriptor = Create(steps, overrideSteps, otherStep);
                    overrideSteps.Add(descriptor);
                }

                yield return descriptor;
            }
        }

        /// <summary>
        /// The descriptor is just a description of the step, and it's uniqueness is based on the step itself.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Step.GetHashCode();
        }

        /// <summary>
        /// The descriptor is just a description of the step, and it's equality is based on the step itself.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return Step.Equals(((StepDescriptor<TReturn>)obj).Step);
        }

        // Handing for debugging.
        public override string ToString()
        {
            if (DependsOn != null && DependsOn.Any())
                return $"Step {Name} {{ DependsOn: {string.Join(", ", DependsOn.Select(x => x.StepType.Name))} }}";
            return $"Step {Name}";
        }

        public bool CanRun(Type type) => Step.CanRun(type) && (!Overrides.Any() || !Overrides.Any(z => z.CanRun(type)));
        public bool CanExecute(object instance) => Step.CanExecute(instance) && (!Overrides.Any() || !Overrides.Any(z => z.CanExecute(instance)));
        public TReturn Execute(IServiceProvider serviceProvider, object instance) => ExecuteFunc(serviceProvider, instance);
    }
}
