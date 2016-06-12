using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacklite.Domain.Steps
{
    public interface IPhasedStepProvider<TStep, TReturn>
           where TStep : IPhasedStep
    {
        /// <summary>
        /// Get a list of all steps for the given phase
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="phase"></param>
        /// <param name="context"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        IEnumerable<IStepDescriptor<TReturn>> GetStepsForPhase([NotNull]IStepPhase phase, [NotNull] Type type);
    }

    public class PhasedStepProvider<TStep, TReturn> : IPhasedStepProvider<TStep, TReturn>
        where TStep : IPhasedStep
    {
        protected IPhasedStepCache<TStep, TReturn> StepCache { get; }

        public PhasedStepProvider(IPhasedStepCache<TStep, TReturn> stepCache)
        {
            StepCache = stepCache;
        }

        public IEnumerable<IStepDescriptor<TReturn>> GetStepsForPhase(IStepPhase phase, Type type)
        {
            IStepContainer<TReturn> value;
            if (StepCache.TryGetValue(phase, out value))
                return value.GetStepsForContext(type)
                    // Overrides are process steps that derive from the given step
                    // If they "CanExecute" then this step, by it's nature should not execute.
                    // because the "override" will also be in the list of possible steps for a given type.
                    // and we should not run the same step more than once.
                    .Where(step => step.CanExecute(context, type));

            return Enumerable.Empty<IStepDescriptor<TReturn>>();
        }
    }
}
