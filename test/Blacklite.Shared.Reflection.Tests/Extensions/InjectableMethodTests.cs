using Shared.Reflection.Tests.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Blacklite.Shared.Reflection.Extensions.InjectorExtension;
using System.Reflection;
using Moq;

namespace Shared.Reflection.Tests.Extensions
{
    public class MethodFuncTest
    {
        public virtual void Execute() { }
        public virtual void Execute(IConfigured1 i1) { }
        public virtual void Execute(IInstance instance) { }
        public virtual void Execute(IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IConfigured12 i12, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IConfigured12 i12, IConfigured13 i13, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }
        public virtual void Execute(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IConfigured12 i12, IConfigured13 i13, IConfigured14 i14, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { }

        public virtual bool ExecuteReturn() { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1) { return true; }
        public virtual bool ExecuteReturn(IInstance instance) { return true; }
        public virtual bool ExecuteReturn(IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IConfigured12 i12, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IConfigured12 i12, IConfigured13 i13, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }
        public virtual bool ExecuteReturn(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IConfigured12 i12, IConfigured13 i13, IConfigured14 i14, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return true; }

        public virtual IEnumerable<IReturn> ExecuteEnumerable() { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IInstance instance) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IConfigured12 i12, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IConfigured12 i12, IConfigured13 i13, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
        public virtual IEnumerable<IReturn> ExecuteEnumerable(IConfigured1 i1, IConfigured2 i2, IConfigured3 i3, IConfigured4 i4, IConfigured5 i5, IConfigured6 i6, IConfigured7 i7, IConfigured8 i8, IConfigured9 i9, IConfigured10 i10, IConfigured11 i11, IConfigured12 i12, IConfigured13 i13, IConfigured14 i14, IInstance instance, IInjected1 n1, IInjected2 n2, IInjected3 n3 = null) { return Enumerable.Empty<IReturn>(); }
    }

    public class InjectableMethodTests
    {
        [Fact]
        public void MapsActionAndExecutes()
        {
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 0);

            var method = new InjectableMethod(
                methodInfo,
                null,
                new ConfiguredParameter[] { },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );


            var action = method.CreateAction(methodFuncTestMock.Object);
            action(It.IsNotNull<IServiceProvider>());

            methodFuncTestMock.Verify(x => x.Execute(), Times.AtLeastOnce);
        }

        [Fact]
        public void MapsConfiguredParameterToAction()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(null);

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 1 && x.GetParameters().Single().ParameterType == typeof(IConfigured1));

            var method = new InjectableMethod(
                methodInfo,
                null,
                new[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .SingleOrDefault(x => x.ParameterType == typeof(IConfigured1)), false)
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>()), Times.AtLeastOnce);
        }

        [Fact]
        public void MapsInstanceParameterToAction()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 1 && x.GetParameters().Single().ParameterType == typeof(IInstance));

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(typeof(IInstance), instance => parameterInfo => parameterInfo.ParameterType.GetTypeInfo().IsAssignableFrom(instance.GetTypeInfo()), false),
                new ConfiguredParameter[] { },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IInstance>()), Times.AtLeastOnce);
        }

        [Fact]
        public void InjectsAllServices()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 3);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(typeof(IInstance), instance => parameterInfo => parameterInfo.ParameterType.GetTypeInfo().IsAssignableFrom(instance.GetTypeInfo()), true),
                new ConfiguredParameter[] { },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction(methodFuncTestMock.Object);
            action(serviceProvider);
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void InjectsAllServicesSafely()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(null);

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 3);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(typeof(IInstance), instance => parameterInfo => parameterInfo.ParameterType.GetTypeInfo().IsAssignableFrom(instance.GetTypeInfo()), true),
                new ConfiguredParameter[] { },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction(methodFuncTestMock.Object);
            action(serviceProvider);
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), null), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures1Service()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 5);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures2Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 6);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures3Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 7);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures4Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 8);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures5Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 9);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures6Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 10);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures7Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 11);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures8Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 12);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures9Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 13);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures10Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 14);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured10)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IConfigured10, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IConfigured10>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IConfigured10>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures11Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 15);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured10)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured11)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IConfigured10, IConfigured11, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IConfigured10>(), Mock.Of<IConfigured11>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IConfigured10>(), It.IsNotNull<IConfigured11>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures12Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 16);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured10)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured11)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured12)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IConfigured10, IConfigured11, IConfigured12, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IConfigured10>(), Mock.Of<IConfigured11>(), Mock.Of<IConfigured12>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IConfigured10>(), It.IsNotNull<IConfigured11>(), It.IsNotNull<IConfigured12>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures13Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 17);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured10)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured11)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured12)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured13)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IConfigured10, IConfigured11, IConfigured12, IConfigured13, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IConfigured10>(), Mock.Of<IConfigured11>(), Mock.Of<IConfigured12>(), Mock.Of<IConfigured13>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IConfigured10>(), It.IsNotNull<IConfigured11>(), It.IsNotNull<IConfigured12>(), It.IsNotNull<IConfigured13>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures14Services()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 18);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured10)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured11)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured12)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured13)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured14)), false)
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateAction<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IConfigured10, IConfigured11, IConfigured12, IConfigured13, IConfigured14, IInstance>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IConfigured10>(), Mock.Of<IConfigured11>(), Mock.Of<IConfigured12>(), Mock.Of<IConfigured13>(), Mock.Of<IConfigured14>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IConfigured10>(), It.IsNotNull<IConfigured11>(), It.IsNotNull<IConfigured12>(), It.IsNotNull<IConfigured13>(), It.IsNotNull<IConfigured14>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void MapsConfiguredParameterToFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(null);

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 1 && x.GetParameters().Single().ParameterType == typeof(IConfigured1));

            var method = new InjectableMethod(
                methodInfo,
                null,
                new[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .SingleOrDefault(x => x.ParameterType == typeof(IConfigured1)), false)
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>()), Times.AtLeastOnce);
        }

        [Fact]
        public void MapsInstanceParameterToFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 1 && x.GetParameters().Single().ParameterType == typeof(IInstance));

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(typeof(IInstance), instance => parameterInfo => parameterInfo.ParameterType.GetTypeInfo().IsAssignableFrom(instance.GetTypeInfo()), false),
                new ConfiguredParameter[] { },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IInstance>()), Times.AtLeastOnce);
        }

        [Fact]
        public void InjectsAllServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 3);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(typeof(IInstance), instance => parameterInfo => parameterInfo.ParameterType.GetTypeInfo().IsAssignableFrom(instance.GetTypeInfo()), true),
                new ConfiguredParameter[] { },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IReturn>(methodFuncTestMock.Object);
            action(serviceProvider);
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void InjectsAllServicesSafelyFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(null);

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 3);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(typeof(IInstance), instance => parameterInfo => parameterInfo.ParameterType.GetTypeInfo().IsAssignableFrom(instance.GetTypeInfo()), true),
                new ConfiguredParameter[] { },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IReturn>(methodFuncTestMock.Object);
            action(serviceProvider);
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), null), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures1ServiceFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 5);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures2ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 6);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures3ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 7);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures4ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 8);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures5ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 9);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures6ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 10);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures7ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 11);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures8ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 12);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures9ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 13);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures10ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 14);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured10)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IConfigured10, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IConfigured10>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IConfigured10>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures11ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 15);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured10)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured11)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IConfigured10, IConfigured11, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IConfigured10>(), Mock.Of<IConfigured11>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IConfigured10>(), It.IsNotNull<IConfigured11>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures12ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 16);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured10)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured11)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured12)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IConfigured10, IConfigured11, IConfigured12, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IConfigured10>(), Mock.Of<IConfigured11>(), Mock.Of<IConfigured12>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IConfigured10>(), It.IsNotNull<IConfigured11>(), It.IsNotNull<IConfigured12>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures13ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 17);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured10)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured11)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured12)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured13)), false),
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IConfigured10, IConfigured11, IConfigured12, IConfigured13, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IConfigured10>(), Mock.Of<IConfigured11>(), Mock.Of<IConfigured12>(), Mock.Of<IConfigured13>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IConfigured10>(), It.IsNotNull<IConfigured11>(), It.IsNotNull<IConfigured12>(), It.IsNotNull<IConfigured13>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Configures14ServicesFunc()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 18);

            var method = new InjectableMethod(
                methodInfo,
                new InstanceParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IInstance)), false),
                new ConfiguredParameter[] {
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured1)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured2)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured3)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured4)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured5)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured6)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured7)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured8)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured9)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured10)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured11)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured12)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured13)), false),
                    new ConfiguredParameter(methodInfo
                        .GetParameters()
                        .Single(x => x.ParameterType == typeof(IConfigured14)), false)
                },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IConfigured1, IConfigured2, IConfigured3, IConfigured4, IConfigured5, IConfigured6, IConfigured7, IConfigured8, IConfigured9, IConfigured10, IConfigured11, IConfigured12, IConfigured13, IConfigured14, IInstance, IReturn>(methodFuncTestMock.Object);
            action(serviceProvider, Mock.Of<IConfigured1>(), Mock.Of<IConfigured2>(), Mock.Of<IConfigured3>(), Mock.Of<IConfigured4>(), Mock.Of<IConfigured5>(), Mock.Of<IConfigured6>(), Mock.Of<IConfigured7>(), Mock.Of<IConfigured8>(), Mock.Of<IConfigured9>(), Mock.Of<IConfigured10>(), Mock.Of<IConfigured11>(), Mock.Of<IConfigured12>(), Mock.Of<IConfigured13>(), Mock.Of<IConfigured14>(), Mock.Of<IInstance>());
            methodFuncTestMock.Verify(x => x.Execute(It.IsNotNull<IConfigured1>(), It.IsNotNull<IConfigured2>(), It.IsNotNull<IConfigured3>(), It.IsNotNull<IConfigured4>(), It.IsNotNull<IConfigured5>(), It.IsNotNull<IConfigured6>(), It.IsNotNull<IConfigured7>(), It.IsNotNull<IConfigured8>(), It.IsNotNull<IConfigured9>(), It.IsNotNull<IConfigured10>(), It.IsNotNull<IConfigured11>(), It.IsNotNull<IConfigured12>(), It.IsNotNull<IConfigured13>(), It.IsNotNull<IConfigured14>(), It.IsNotNull<IInstance>(), It.IsNotNull<IInjected1>(), It.IsNotNull<IInjected2>(), It.IsNotNull<IInjected3>()), Times.AtLeastOnce);
        }

        [Fact]
        public void ReturnsExpectedTypesWhenInCompatibleTypeIsPresented()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();
            methodFuncTestMock.Setup(x => x.ExecuteReturn()).Returns(true);

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.ExecuteEnumerable))
                    .Single(x => x.GetParameters().Count() == 0);

            var method = new InjectableMethod(
                methodInfo,
                null,
                new ConfiguredParameter[] { },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<bool>(methodFuncTestMock.Object);
            var result = action(serviceProvider);

            Assert.False(result);

            methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 0);

            method = new InjectableMethod(
               methodInfo,
               null,
               new ConfiguredParameter[] { },
               new Dictionary<TypeInfo, ConfiguredParameter>()
           );

            action = method.CreateFunc<bool>(methodFuncTestMock.Object);
            result = action(serviceProvider);

            Assert.False(result);

            methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.ExecuteReturn))
                    .Single(x => x.GetParameters().Count() == 0);

            method = new InjectableMethod(
               methodInfo,
               null,
               new ConfiguredParameter[] { },
               new Dictionary<TypeInfo, ConfiguredParameter>()
           );

            action = method.CreateFunc<bool>(methodFuncTestMock.Object);
            result = action(serviceProvider);

            Assert.True(result);
        }

        [Fact]
        public void ReturnsAnEmptyEnumerableWhenReturnTypeIsEnumerable()
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected1))).Returns(Mock.Of<IInjected1>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected2))).Returns(Mock.Of<IInjected2>());
            serviceProviderMock.Setup(x => x.GetService(typeof(IInjected3))).Returns(Mock.Of<IInjected3>());

            var serviceProvider = serviceProviderMock.Object;
            var methodFuncTestMock = new Mock<MethodFuncTest>();
            methodFuncTestMock.Setup(x => x.ExecuteEnumerable()).Returns(new[] { Mock.Of<IReturn>(), Mock.Of<IReturn>(), Mock.Of<IReturn>() });

            var methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.ExecuteEnumerable))
                    .Single(x => x.GetParameters().Count() == 0);

            var method = new InjectableMethod(
                methodInfo,
                null,
                new ConfiguredParameter[] { },
                new Dictionary<TypeInfo, ConfiguredParameter>()
            );

            var action = method.CreateFunc<IEnumerable<IReturn>>(methodFuncTestMock.Object);
            var result = action(serviceProvider);

            Assert.NotNull(result);
            Assert.True(result.Any());

            methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.Execute))
                    .Single(x => x.GetParameters().Count() == 0);

            method = new InjectableMethod(
               methodInfo,
               null,
               new ConfiguredParameter[] { },
               new Dictionary<TypeInfo, ConfiguredParameter>()
           );

            action = method.CreateFunc<IEnumerable<IReturn>>(methodFuncTestMock.Object);
            result = action(serviceProvider);

            Assert.NotNull(result);
            Assert.False(result.Any());

            methodInfo = typeof(MethodFuncTest).GetTypeInfo().DeclaredMethods
                    .Where(x => x.Name == nameof(MethodFuncTest.ExecuteReturn))
                    .Single(x => x.GetParameters().Count() == 0);

            method = new InjectableMethod(
               methodInfo,
               null,
               new ConfiguredParameter[] { },
               new Dictionary<TypeInfo, ConfiguredParameter>()
           );

            action = method.CreateFunc<IEnumerable<IReturn>>(methodFuncTestMock.Object);
            result = action(serviceProvider);

            Assert.NotNull(result);
            Assert.False(result.Any());
        }
    }
}
