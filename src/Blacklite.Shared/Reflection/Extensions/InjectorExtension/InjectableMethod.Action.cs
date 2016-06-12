using System;

namespace Blacklite.Shared.Reflection.Extensions.InjectorExtension
{
    partial class InjectableMethod
    {
        public Action<IServiceProvider> CreateAction(object container)
        {
            return (IServiceProvider serviceProvider) =>
            {
                var parameters = new object[_numParams];
                InjectParameters(serviceProvider, parameters);
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1> CreateAction<T1>(object container)
        {
            return (IServiceProvider serviceProvider, T1 t1) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                InjectParameters(serviceProvider, parameters);
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2> CreateAction<T1, T2>(object container)
        {
            return (IServiceProvider serviceProvider, T1 t1, T2 t2) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                InjectParameters(serviceProvider, parameters);
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3> CreateAction<T1, T2, T3>(object container)
        {
            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                InjectParameters(serviceProvider, parameters);
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4> CreateAction<T1, T2, T3, T4>(object container)
        {
            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                InjectParameters(serviceProvider, parameters);
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5> CreateAction<T1, T2, T3, T4, T5>(object container)
        {
            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                InjectParameters(serviceProvider, parameters);
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6> CreateAction<T1, T2, T3, T4, T5, T6>(object container)
        {
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
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7> CreateAction<T1, T2, T3, T4, T5, T6, T7>(object container)
        {
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
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8>(object container)
        {
            return (IServiceProvider serviceProvider, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) =>
            {
                var parameters = new object[_numParams];
                SetConfiguredParameter(parameters, t1);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t2);
                SetConfiguredParameter(parameters, t3);
                SetConfiguredParameter(parameters, t4);
                SetConfiguredParameter(parameters, t5);
                SetConfiguredParameter(parameters, t6);
                SetConfiguredParameter(parameters, t7);
                SetConfiguredParameter(parameters, t8);
                InjectParameters(serviceProvider, parameters);
                ExecuteResult(container, parameters);
            };
        }


        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object container)
        {
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
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(object container)
        {
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
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(object container)
        {
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
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(object container)
        {
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
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(object container)
        {
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
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(object container)
        {
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
                ExecuteResult(container, parameters);
            };
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(object container)
        {
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
                ExecuteResult(container, parameters);
            };
        }
    }

}
