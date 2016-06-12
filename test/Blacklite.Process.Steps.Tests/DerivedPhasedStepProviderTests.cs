using Blacklite.Steps;
using Moq;
using Steps.Tests.Fixtures;
using System;
using System.Collections.Generic;
using Xunit;

namespace Steps.Tests
{
    public class DerivedPhasedStepProviderTests
    {
        public interface IDerviedStepContext : IStepContext
        {

        }

        public interface IDerivedStep : IPhasedStep
        {

        }

        public interface IDerivedStepProvider : IPhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>
        {

        }

        class DerivedStepProvider : PhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>, IDerivedStepProvider
        {
            public DerivedStepProvider(IPhasedStepCache<IPhasedStep, IEnumerable<IValidation>> stepCache) : base(stepCache)
            {
            }
        }

        public interface IDerivedStepCache : IPhasedStepCache<IPhasedStep, IEnumerable<IValidation>>
        {

        }

        class DerivedStepCache : DefaultPhasedStepCache<IPhasedStep, IEnumerable<IValidation>>, IDerivedStepCache
        {
            public DerivedStepCache(IEnumerable<IPhasedStep> steps) : base(steps)
            {
            }
        }

        public abstract class DerivedStepVoidExecute : IDerivedStep
        {
            public virtual bool CanExecute(IStepContext context, object instance) => true;

            public virtual bool CanRun(Type type) => true;

            public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

            public abstract void Execute(object instance);
        }

        public abstract class DerivedStepVoidExecuteContext : IDerivedStep
        {
            public virtual bool CanExecute(IStepContext context, object instance) => true;

            public virtual bool CanRun(Type type) => true;

            public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

            public abstract void Execute(IDerviedStepContext context, object instance);
        }

        public abstract class DerivedStepVoidExecuteInjectable : IDerivedStep
        {
            public virtual bool CanExecute(IStepContext context, object instance) => true;

            public virtual bool CanRun(Type type) => true;

            public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

            public abstract void Execute(object instance, IDerviedStepContext context, IInjectable injectable);
        }

        public abstract class DerivedStepValidationExecute : IDerivedStep
        {
            public virtual bool CanExecute(IStepContext context, object instance) => true;

            public virtual bool CanRun(Type type) => true;

            public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

            public abstract IEnumerable<IValidation> Execute(object instance);
        }

        public abstract class DerivedStepValidationExecuteContext : IDerivedStep
        {
            public virtual bool CanExecute(IStepContext context, object instance) => true;

            public virtual bool CanRun(Type type) => true;

            public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

            public abstract IEnumerable<IValidation> Execute(object instance, IDerviedStepContext context);
        }

        public abstract class DerivedStepValidationExecuteInjectable : IDerivedStep
        {
            public virtual bool CanExecute(IStepContext context, object instance) => true;

            public virtual bool CanRun(Type type) => true;

            public virtual IEnumerable<IStepPhase> Phases => StepPhases.Init;

            public abstract IEnumerable<IValidation> Execute(object instance, IDerviedStepContext context, IInjectable injectable);
        }


        [Fact]
        public void StepsExecutePropertyWithADerivedStepContext()
        {

            var context = new object();
            var processContextMock = new Mock<IDerviedStepContext>();
            var processContext = processContextMock.Object;

            var serviceProviderMock = new Mock<IServiceProvider>();
            var serviceProvider = serviceProviderMock.Object;

            var injectableMock = new Mock<IInjectable>();
            var injectable = injectableMock.Object;

            serviceProviderMock.Setup(x => x.GetService(typeof(IInjectable))).Returns(injectableMock.Object);
            processContextMock.SetupGet(x => x.ServiceProvider).Returns(serviceProviderMock.Object);

            var voidExecuteMock = new Mock<DerivedStepVoidExecute>();
            var voidExecuteContextMock = new Mock<DerivedStepVoidExecuteContext>();
            var voidExecuteInjectableMock = new Mock<DerivedStepVoidExecuteInjectable>();
            voidExecuteMock.Setup(x => x.Execute(context));
            voidExecuteMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            voidExecuteMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            voidExecuteMock.Setup(x => x.CanExecute(processContext, context)).Returns(true);

            voidExecuteContextMock.Setup(x => x.Execute(processContext, context));
            voidExecuteContextMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            voidExecuteContextMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            voidExecuteContextMock.Setup(x => x.CanExecute(processContext, context)).Returns(true);

            voidExecuteInjectableMock.Setup(x => x.Execute(context, processContext, injectable));
            voidExecuteInjectableMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            voidExecuteInjectableMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            voidExecuteInjectableMock.Setup(x => x.CanExecute(processContext, context)).Returns(true);


            var validationExecuteMock = new Mock<DerivedStepValidationExecute>();
            var validationExecuteContextMock = new Mock<DerivedStepValidationExecuteContext>();
            var validationExecuteInjectableMock = new Mock<DerivedStepValidationExecuteInjectable>();
            validationExecuteMock.Setup(x => x.Execute(context));
            validationExecuteMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            validationExecuteMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            validationExecuteMock.Setup(x => x.CanExecute(It.IsAny<IDerviedStepContext>(), It.IsAny<object>())).Returns(true);

            validationExecuteContextMock.Setup(x => x.Execute(context, processContext));
            validationExecuteContextMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            validationExecuteContextMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            validationExecuteContextMock.Setup(x => x.CanExecute(It.IsAny<IDerviedStepContext>(), It.IsAny<object>())).Returns(true);

            validationExecuteInjectableMock.Setup(x => x.Execute(context, processContext, injectable));
            validationExecuteInjectableMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            validationExecuteInjectableMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            validationExecuteInjectableMock.Setup(x => x.CanExecute(It.IsAny<IDerviedStepContext>(), It.IsAny<object>())).Returns(true);

            var mockSteps = new IDerivedStep[]
            {
                voidExecuteMock.Object,
                voidExecuteContextMock.Object,
                voidExecuteInjectableMock.Object,
                validationExecuteMock.Object,
                validationExecuteContextMock.Object,
                validationExecuteInjectableMock.Object
            };

            var provider = new DerivedStepProvider(new DerivedStepCache(mockSteps));

            var steps = provider.GetStepsForPhase(StepPhases.Init, processContext, context);

            foreach (var step in steps)
            {
                step.Execute(serviceProvider, processContext, context);
            }

            voidExecuteMock.Verify(x => x.Execute(context));
            voidExecuteContextMock.Verify(x => x.Execute(processContext, context));
            voidExecuteInjectableMock.Verify(x => x.Execute(context, processContext, injectable));

            validationExecuteMock.Verify(x => x.Execute(context));
            validationExecuteContextMock.Verify(x => x.Execute(context, processContext));
            validationExecuteInjectableMock.Verify(x => x.Execute(context, processContext, injectable));
        }
    }
}
