using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blacklite.Shared.Reflection.Extensions.InjectorExtension
{
    public partial class InjectableMethodBuilder
    {
        public Action<IServiceProvider> CreateAction([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(0);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction(container);
        }

        public Action<IServiceProvider, T1> CreateAction<T1>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(1);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1>(container);
        }

        public Action<IServiceProvider, T1, T2> CreateAction<T1, T2>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(2);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2>(container);
        }

        public Action<IServiceProvider, T1, T2, T3> CreateAction<T1, T2, T3>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(3);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4> CreateAction<T1, T2, T3, T4>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(4);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5> CreateAction<T1, T2, T3, T4, T5>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(5);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6> CreateAction<T1, T2, T3, T4, T5, T6>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(6);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7> CreateAction<T1, T2, T3, T4, T5, T6, T7>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(7);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(8);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(9);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(10);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(11);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(12);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(13);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T13), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(14);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T13), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T14), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(15);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T13), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T14), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T15), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(container);
        }
    }
}
