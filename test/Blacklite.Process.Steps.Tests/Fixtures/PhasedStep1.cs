using Blacklite.Steps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Steps.Tests.Fixtures
{
    public interface IValidation { }

    [BeforeStep(typeof(PhasedStepInitPhases))]
    public class PhasedStepInit : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(object instance)
        {
        }
    }

    [BeforeStep(typeof(PhasedStepAllPhases))]
    public class PhasedStepPostInit : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.PostInit;

        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(PhasedStepAllPhases))]
    public class PhasedStepPreInit : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.PreInit;

        public IEnumerable<IValidation> Execute(object instance)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    public class PhasedStepInitPhases : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.InitPhases;

        public IEnumerable<IValidation> Execute(IStepContext context, object instance)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    [BeforeStep(typeof(PhasedStepAllPhases))]
    public class PhasedStepPreSave : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.PreSave;
        public IEnumerable<IValidation> Execute(object instance, IStepContext context)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    [BeforeStep(typeof(PhasedStepAllPhases))]
    public class PhasedStepSave : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Save;
        public void Execute(object instance, IStepContext context, IInjectable injectable)
        {
        }
    }

    [BeforeStep(typeof(PhasedStepAllPhases))]
    public class PhasedStepValidate : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Validate;
        public IEnumerable<IValidation> Execute(object instance, IInjectable injectable)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    [BeforeStep(typeof(PhasedStepSavePhases))]
    [BeforeStep(typeof(PhasedStepAllPhases))]
    public class PhasedStepPostSave : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.PostSave;
        public void Execute(object instance, IInjectable injectable)
        {
        }
    }
    public class PhasedStepSavePhases : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.SavePhases;
        public IEnumerable<IValidation> Execute(object instance, IStepContext context, IInjectable injectable)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    [AfterStep(typeof(PhasedStepInitPhases))]
    [AfterStep(typeof(PhasedStepSavePhases))]
    public class PhasedStepAllPhases : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.AllPhases;
        public IEnumerable<IValidation> Execute(object instance, IStepContext context, IInjectable injectable)
        {
            return Enumerable.Empty<IValidation>();
        }
    }

    public abstract class PhasedStepVoidExecute : IPhasedStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public abstract void Execute(object instance);
    }

    public abstract class PhasedStepVoidExecuteContext : IPhasedStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public abstract void Execute(object instance, IStepContext context);
    }

    public abstract class PhasedStepVoidExecuteInjectable : IPhasedStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public abstract void Execute(object instance, IStepContext context, IInjectable injectable);
    }

    public abstract class PhasedStepValidationExecute : IPhasedStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public abstract IEnumerable<IValidation> Execute(object instance);
    }

    public abstract class PhasedStepValidationExecuteContext : IPhasedStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public abstract IEnumerable<IValidation> Execute(object instance, IStepContext context);
    }

    public abstract class PhasedStepValidationExecuteInjectable : IPhasedStep
    {
        public virtual bool CanExecute(IStepContext context, object instance) => true;

        public virtual bool CanRun(Type type) => true;

        public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public abstract IEnumerable<IValidation> Execute(object instance, IStepContext context, IInjectable injectable);
    }

    [BeforeStep(typeof(PhasedCyclicBefore1StepB))]
    public class PhasedCyclicBefore1StepA : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(object instance)
        {
        }
    }

    [BeforeStep(typeof(PhasedCyclicBefore1StepA))]
    public class PhasedCyclicBefore1StepB : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [BeforeStep(typeof(PhasedCyclicBefore2StepB))]
    public class PhasedCyclicBefore2StepA : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [BeforeStep(typeof(PhasedCyclicBefore2StepC))]
    public class PhasedCyclicBefore2StepB : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [BeforeStep(typeof(PhasedCyclicBefore2StepA))]
    public class PhasedCyclicBefore2StepC : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(PhasedCyclicAfter1StepB))]
    public class PhasedCyclicAfter1StepA : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(object instance)
        {
        }
    }

    [AfterStep(typeof(PhasedCyclicAfter1StepA))]
    public class PhasedCyclicAfter1StepB : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(PhasedCyclicAfter2StepB))]
    public class PhasedCyclicAfter2StepA : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(PhasedCyclicAfter2StepC))]
    public class PhasedCyclicAfter2StepB : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(PhasedCyclicAfter2StepA))]
    public class PhasedCyclicAfter2StepC : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [BeforeStep(typeof(PhasedCyclicBeforeAfterStep1StepB))]
    [AfterStep(typeof(PhasedCyclicBeforeAfterStep1StepC))]
    public class PhasedCyclicBeforeAfterStep1StepA : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }
    public class PhasedCyclicBeforeAfterStep1StepB : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }

    [AfterStep(typeof(PhasedCyclicBeforeAfterStep1StepB))]
    public class PhasedCyclicBeforeAfterStep1StepC : PhasedStep<object>
    {
        public override IEnumerable<IStepPhase> Phases => StepPhases.Init;

        public void Execute(IStepContext context, object instance)
        {
        }
    }
}
