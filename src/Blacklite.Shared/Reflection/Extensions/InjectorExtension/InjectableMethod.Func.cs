using System;
using System.Reflection;

namespace Blacklite.Shared.Reflection.Extensions.InjectorExtension
{
    partial class InjectableMethod
    {
        public Func<IServiceProvider, TReturn> CreateFunc<TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider) =>
            {
                var parameters = new object[_numParams];
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, TReturn> CreateFunc<T1, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, TReturn> CreateFunc<T1, T2, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, TReturn> CreateFunc<T1, T2, T3, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, TReturn> CreateFunc<T1, T2, T3, T4, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, TReturn> CreateFunc<T1, T2, T3, T4, T5, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                SetConfiguredParameter(parameters, t7);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                SetConfiguredParameter(parameters, t7);
                SetConfiguredParameter(parameters, t8);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }


        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                SetConfiguredParameter(parameters, t7);
                SetConfiguredParameter(parameters, t8);
                SetConfiguredParameter(parameters, t9);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                SetConfiguredParameter(parameters, t7);
                SetConfiguredParameter(parameters, t8);
                SetConfiguredParameter(parameters, t9);
                SetConfiguredParameter(parameters, t10);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                SetConfiguredParameter(parameters, t7);
                SetConfiguredParameter(parameters, t8);
                SetConfiguredParameter(parameters, t9);
                SetConfiguredParameter(parameters, t10);
                SetConfiguredParameter(parameters, t11);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                SetConfiguredParameter(parameters, t7);
                SetConfiguredParameter(parameters, t8);
                SetConfiguredParameter(parameters, t9);
                SetConfiguredParameter(parameters, t10);
                SetConfiguredParameter(parameters, t11);
                SetConfiguredParameter(parameters, t12);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                SetConfiguredParameter(parameters, t7);
                SetConfiguredParameter(parameters, t8);
                SetConfiguredParameter(parameters, t9);
                SetConfiguredParameter(parameters, t10);
                SetConfiguredParameter(parameters, t11);
                SetConfiguredParameter(parameters, t12);
                SetConfiguredParameter(parameters, t13);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                SetConfiguredParameter(parameters, t7);
                SetConfiguredParameter(parameters, t8);
                SetConfiguredParameter(parameters, t9);
                SetConfiguredParameter(parameters, t10);
                SetConfiguredParameter(parameters, t11);
                SetConfiguredParameter(parameters, t12);
                SetConfiguredParameter(parameters, t13);
                SetConfiguredParameter(parameters, t14);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn>(object container)
        {
            // if return is enumerable then the default should be empty, not null.
            var returnTypeInfo = typeof(TReturn).GetTypeInfo();
            var returnDefault = GetDefaultReturnValue<TReturn>(returnTypeInfo);

            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                SetConfiguredParameter(parameters, t7);
                SetConfiguredParameter(parameters, t8);
                SetConfiguredParameter(parameters, t9);
                SetConfiguredParameter(parameters, t10);
                SetConfiguredParameter(parameters, t11);
                SetConfiguredParameter(parameters, t12);
                SetConfiguredParameter(parameters, t13);
                SetConfiguredParameter(parameters, t14);
                SetConfiguredParameter(parameters, t15);
                InjectParameters(serviceProvider, parameters);
                return GetResult(container, parameters, returnDefault, returnTypeInfo);
            };
        }
    }

}
