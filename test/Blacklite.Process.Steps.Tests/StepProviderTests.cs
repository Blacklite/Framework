using System;
using Xunit;
using Moq;
using Steps.Tests.Fixtures;
using System.Linq;
using Blacklite.Steps;
using System.Collections.Generic;

namespace Steps.Tests
{
    public class StepProviderTests
    {
        [Fact]
        public void ResolvesSteps()
        {
            var stepPreInit = new StepPreInit();
            var stepInit = new StepInit();
            var stepPostInit = new StepPostInit();
            var stepPreSave = new StepPreSave();
            var stepValidate = new StepValidate();
            var stepSave = new StepSave();
            var stepPostSave = new StepPostSave();
            var stepInitPhases = new StepInitPhases();
            var stepSavePhases = new StepSavePhases();
            var stepAllPhases = new StepAllPhases();
            var mockSteps = new IStep[]
            {
                stepPreInit,
                stepInit,
                stepPostInit,
                stepPreSave,
                stepValidate,
                stepPostSave,
                stepInitPhases,
                stepAllPhases
            };

            var provider = new StepProvider<IStep, IEnumerable<IValidation>>(new DefaultStepCache<IStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetSteps(It.IsAny<IStepContext>(), new object());

            //Assert.Equal(3, steps.Count());

            var underlyingSteps = steps.Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step);

            Assert.Contains(stepPreInit, underlyingSteps);
            Assert.Contains(stepInit, underlyingSteps);
            Assert.Contains(stepPostInit, underlyingSteps);
            Assert.Contains(stepPreSave, underlyingSteps);
            Assert.Contains(stepValidate, underlyingSteps);
            Assert.DoesNotContain(stepSave, underlyingSteps);
            Assert.Contains(stepPostSave, underlyingSteps);
            Assert.Contains(stepInitPhases, underlyingSteps);
            Assert.DoesNotContain(stepSavePhases, underlyingSteps);
            Assert.Contains(stepAllPhases, underlyingSteps);
        }

        [Fact]
        public void StepsOrderCorrectly()
        {
            var stepPreInit = new StepPreInit();
            var stepInit = new StepInit();
            var stepPostInit = new StepPostInit();
            var stepPreSave = new StepPreSave();
            var stepValidate = new StepValidate();
            var stepSave = new StepSave();
            var stepPostSave = new StepPostSave();
            var stepInitPhases = new StepInitPhases();
            var stepSavePhases = new StepSavePhases();
            var stepAllPhases = new StepAllPhases();
            var mockSteps = new IStep[]
            {
                stepPreInit,
                stepInit,
                stepPostInit,
                stepPreSave,
                stepValidate,
                stepSave,
                stepPostSave,
                stepInitPhases,
                stepSavePhases,
                stepAllPhases
            };

            var provider = new StepProvider<IStep, IEnumerable<IValidation>>(new DefaultStepCache<IStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetSteps(It.IsAny<IStepContext>(), new object()).Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step).ToArray();

            Assert.Same(steps[0], stepInit);
            Assert.Same(steps[1], stepInitPhases);
            Assert.Same(steps[2], stepPostSave);
            Assert.Same(steps[3], stepSavePhases);
            Assert.Same(steps[4], stepPostInit);
            Assert.Same(steps[5], stepPreSave);
            Assert.Same(steps[6], stepValidate);
            Assert.Same(steps[7], stepSave);
            Assert.Same(steps[8], stepAllPhases);
            Assert.Same(steps[9], stepPreInit);
        }

        [Fact]
        public void StepsExecuteProperty()
        {

            var context = new object();
            var processContextMock = new Mock<IStepContext>();
            var processContext = processContextMock.Object;

            var serviceProviderMock = new Mock<IServiceProvider>();
            var serviceProvider = serviceProviderMock.Object;

            var injectableMock = new Mock<IInjectable>();
            var injectable = injectableMock.Object;

            serviceProviderMock.Setup(x => x.GetService(typeof(IInjectable))).Returns(injectableMock.Object);
            processContextMock.SetupGet(x => x.ServiceProvider).Returns(serviceProviderMock.Object);

            var voidExecuteMock = new Mock<StepVoidExecute>();
            var voidExecuteContextMock = new Mock<StepVoidExecuteContext>();
            var voidExecuteInjectableMock = new Mock<StepVoidExecuteInjectable>();
            voidExecuteMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            voidExecuteMock.Setup(x => x.CanExecute(It.IsNotNull<IStepContext>(), It.IsNotNull<object>())).Returns(true);
            voidExecuteMock.Setup(x => x.Execute(context));

            voidExecuteContextMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            voidExecuteContextMock.Setup(x => x.CanExecute(It.IsNotNull<IStepContext>(), It.IsNotNull<object>())).Returns(true);
            voidExecuteContextMock.Setup(x => x.Execute(context, processContext));

            voidExecuteInjectableMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            voidExecuteInjectableMock.Setup(x => x.CanExecute(It.IsNotNull<IStepContext>(), It.IsNotNull<object>())).Returns(true);
            voidExecuteInjectableMock.Setup(x => x.Execute(context, processContext, injectable));


            var validationExecuteMock = new Mock<StepValidationExecute>();
            var validationExecuteContextMock = new Mock<StepValidationExecuteContext>();
            var validationExecuteInjectableMock = new Mock<StepValidationExecuteInjectable>();
            validationExecuteMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            validationExecuteMock.Setup(x => x.CanExecute(It.IsNotNull<IStepContext>(), It.IsNotNull<object>())).Returns(true);
            validationExecuteMock.Setup(x => x.Execute(context));

            validationExecuteContextMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            validationExecuteContextMock.Setup(x => x.CanExecute(It.IsNotNull<IStepContext>(), It.IsNotNull<object>())).Returns(true);
            validationExecuteContextMock.Setup(x => x.Execute(context, processContext));

            validationExecuteInjectableMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            validationExecuteInjectableMock.Setup(x => x.CanExecute(It.IsNotNull<IStepContext>(), It.IsNotNull<object>())).Returns(true);
            validationExecuteInjectableMock.Setup(x => x.Execute(context, processContext, injectable));

            var mockSteps = new IStep[]
            {
                voidExecuteMock.Object,
                voidExecuteContextMock.Object,
                voidExecuteInjectableMock.Object,
                validationExecuteMock.Object,
                validationExecuteContextMock.Object,
                validationExecuteInjectableMock.Object
            };

            var provider = new StepProvider<IStep, IEnumerable<IValidation>>(new DefaultStepCache<IStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetSteps(processContext, context);

            foreach (var step in steps)
            {
                step.Execute(serviceProvider, processContext, context);
            }

            voidExecuteMock.Verify(x => x.Execute(context));
            voidExecuteContextMock.Verify(x => x.Execute(context, processContext));
            voidExecuteInjectableMock.Verify(x => x.Execute(context, processContext, injectable));

            validationExecuteMock.Verify(x => x.Execute(context));
            validationExecuteContextMock.Verify(x => x.Execute(context, processContext));
            validationExecuteInjectableMock.Verify(x => x.Execute(context, processContext, injectable));
        }

        public interface IDerviedStepContext : IStepContext
        {

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

            var voidExecuteMock = new Mock<StepVoidExecute>();
            var voidExecuteContextMock = new Mock<StepVoidExecuteContext>();
            var voidExecuteInjectableMock = new Mock<StepVoidExecuteInjectable>();
            voidExecuteMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            voidExecuteMock.Setup(x => x.CanExecute(It.IsNotNull<IDerviedStepContext>(), It.IsNotNull<object>())).Returns(true);
            voidExecuteMock.Setup(x => x.Execute(context));

            voidExecuteContextMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            voidExecuteContextMock.Setup(x => x.CanExecute(It.IsNotNull<IDerviedStepContext>(), It.IsNotNull<object>())).Returns(true);
            voidExecuteContextMock.Setup(x => x.Execute(context, processContext));

            voidExecuteInjectableMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            voidExecuteInjectableMock.Setup(x => x.CanExecute(It.IsNotNull<IDerviedStepContext>(), It.IsNotNull<object>())).Returns(true);
            voidExecuteInjectableMock.Setup(x => x.Execute(context, processContext, injectable));


            var validationExecuteMock = new Mock<StepValidationExecute>();
            var validationExecuteContextMock = new Mock<StepValidationExecuteContext>();
            var validationExecuteInjectableMock = new Mock<StepValidationExecuteInjectable>();
            validationExecuteMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            validationExecuteMock.Setup(x => x.CanExecute(It.IsNotNull<IDerviedStepContext>(), It.IsNotNull<object>())).Returns(true);
            validationExecuteMock.Setup(x => x.Execute(context));

            validationExecuteContextMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            validationExecuteContextMock.Setup(x => x.CanExecute(It.IsNotNull<IDerviedStepContext>(), It.IsNotNull<object>())).Returns(true);
            validationExecuteContextMock.Setup(x => x.Execute(context, processContext));

            validationExecuteInjectableMock.Setup(x => x.CanRun(It.IsNotNull<Type>())).Returns(true);
            validationExecuteInjectableMock.Setup(x => x.CanExecute(It.IsNotNull<IDerviedStepContext>(), It.IsNotNull<object>())).Returns(true);
            validationExecuteInjectableMock.Setup(x => x.Execute(context, processContext, injectable));

            var mockSteps = new IStep[]
            {
                voidExecuteMock.Object,
                voidExecuteContextMock.Object,
                voidExecuteInjectableMock.Object,
                validationExecuteMock.Object,
                validationExecuteContextMock.Object,
                validationExecuteInjectableMock.Object
            };

            var provider = new StepProvider<IStep, IEnumerable<IValidation>>(new DefaultStepCache<IStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetSteps(processContext, context);

            foreach (var step in steps)
            {
                step.Execute(serviceProvider, processContext, context);
            }

            voidExecuteMock.Verify(x => x.Execute(context));
            voidExecuteContextMock.Verify(x => x.Execute(context, processContext));
            voidExecuteInjectableMock.Verify(x => x.Execute(context, processContext, injectable));

            validationExecuteMock.Verify(x => x.Execute(context));
            validationExecuteContextMock.Verify(x => x.Execute(context, processContext));
            validationExecuteInjectableMock.Verify(x => x.Execute(context, processContext, injectable));
        }

        [Fact]
        public void DetectsCyclicDependencies()
        {
            IStep[] mockSteps;

            mockSteps = new IStep[]
            {
                new CyclicBefore1StepA(),
                new CyclicBefore1StepB(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new DefaultStepCache<IStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IStep[]
            {
                new CyclicBefore2StepA(),
                new CyclicBefore2StepB(),
                new CyclicBefore2StepC(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new DefaultStepCache<IStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IStep[]
            {
                new CyclicAfter1StepA(),
                new CyclicAfter1StepB(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new DefaultStepCache<IStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IStep[]
            {
                new CyclicAfter2StepA(),
                new CyclicAfter2StepB(),
                new CyclicAfter2StepC(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new DefaultStepCache<IStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IStep[]
            {
                new CyclicBeforeAfterStep1StepA(),
                new CyclicBeforeAfterStep1StepB(),
                new CyclicBeforeAfterStep1StepC(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new DefaultStepCache<IStep, IEnumerable<IValidation>>(mockSteps)));
        }
    }
}
