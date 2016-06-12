using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blacklite.Shared.Reflection.Extensions.InjectorExtension
{
    public partial class InjectableMethodBuilder
    {
        public Func<IServiceProvider, TReturn> CreateFunc<TReturn>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(1);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<TReturn>(container);
        }

        public Func<IServiceProvider, T1, TReturn> CreateFunc<T1, TReturn>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(1);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<T1, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, TReturn> CreateFunc<T1, T2, TReturn>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(2);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, TReturn> CreateFunc<T1, T2, T3, TReturn>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(3);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, T3, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, TReturn> CreateFunc<T1, T2, T3, T4, TReturn>([NotNull] object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(4);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _configuredParameters);
            //resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _configuredParameters);

            return new InjectableMethod(_methodInfo, _instanceParameter, _configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, T3, T4, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, TReturn> CreateFunc<T1, T2, T3, T4, T5, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn>([NotNull] object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn>(container);
        }
    }
}
