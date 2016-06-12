using Blacklite.Steps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Steps.Tests.Fixtures
{
    [BeforeStep(typeof(StepInitPhases))]
    public class StepInit : Step<object>
    {


        public void Execute(object instance)
        {
        }
    }

    [BeforeStep(typeof(StepAllPhases))]
    public class StepPostInit : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(StepAllPhases))]
    public class StepPreInit : Step<object>
    {


        public IEnumerable<IValidation> Execute(object instance)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    public class StepInitPhases : Step<object>
    {


        public IEnumerable<IValidation> Execute(IStepContext context, object instance)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    [BeforeStep(typeof(StepAllPhases))]
    public class StepPreSave : Step<object>
    {

        public IEnumerable<IValidation> Execute(object instance, IStepContext context)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    public interface IInjectable { }

    [BeforeStep(typeof(StepAllPhases))]
    public class StepSave : Step<object>
    {

        public void Execute(object instance, IStepContext context, IInjectable injectable)
        {
        }
    }

    [BeforeStep(typeof(StepAllPhases))]
    public class StepValidate : Step<object>
    {

        public IEnumerable<IValidation> Execute(object instance, IInjectable injectable)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    [BeforeStep(typeof(StepSavePhases))]
    [BeforeStep(typeof(StepAllPhases))]
    public class StepPostSave : Step<object>
    {

        public void Execute(object instance, IInjectable injectable)
        {
        }
    }
    public class StepSavePhases : Step<object>
    {

        public IEnumerable<IValidation> Execute(object instance, IStepContext context, IInjectable injectable)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    [AfterStep(typeof(StepInitPhases))]
    [AfterStep(typeof(StepSavePhases))]
    public class StepAllPhases : Step<object>
    {

        public IEnumerable<IValidation> Execute(object instance, IStepContext context, IInjectable injectable)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    public abstract class StepVoidExecute : IStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public abstract void Execute(object instance);
    }

    public abstract class StepVoidExecuteContext : IStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public abstract void Execute(object instance, IStepContext context);
    }

    public abstract class StepVoidExecuteInjectable : IStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public abstract void Execute(object instance, IStepContext context, IInjectable injectable);
    }

    public abstract class StepValidationExecute : IStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public abstract IEnumerable<IValidation> Execute(object instance);
    }

    public abstract class StepValidationExecuteContext : IStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public abstract IEnumerable<IValidation> Execute(object instance, IStepContext context);
    }

    public abstract class StepValidationExecuteInjectable : IStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public abstract IEnumerable<IValidation> Execute(object instance, IStepContext context, IInjectable injectable);
    }

    [BeforeStep(typeof(CyclicBefore1StepB))]
    public class CyclicBefore1StepA : Step<object>
    {


        public void Execute(object instance)
        {
        }
    }

    [BeforeStep(typeof(CyclicBefore1StepA))]
    public class CyclicBefore1StepB : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [BeforeStep(typeof(CyclicBefore2StepB))]
    public class CyclicBefore2StepA : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [BeforeStep(typeof(CyclicBefore2StepC))]
    public class CyclicBefore2StepB : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [BeforeStep(typeof(CyclicBefore2StepA))]
    public class CyclicBefore2StepC : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(CyclicAfter1StepB))]
    public class CyclicAfter1StepA : Step<object>
    {


        public void Execute(object instance)
        {
        }
    }

    [AfterStep(typeof(CyclicAfter1StepA))]
    public class CyclicAfter1StepB : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(CyclicAfter2StepB))]
    public class CyclicAfter2StepA : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(CyclicAfter2StepC))]
    public class CyclicAfter2StepB : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(CyclicAfter2StepA))]
    public class CyclicAfter2StepC : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [BeforeStep(typeof(CyclicBeforeAfterStep1StepB))]
    [AfterStep(typeof(CyclicBeforeAfterStep1StepC))]
    public class CyclicBeforeAfterStep1StepA : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }
    public class CyclicBeforeAfterStep1StepB : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(CyclicBeforeAfterStep1StepB))]
    public class CyclicBeforeAfterStep1StepC : Step<object>
    {


        public void Execute(IStepContext context, object instance)
        {
        }
    }
}
