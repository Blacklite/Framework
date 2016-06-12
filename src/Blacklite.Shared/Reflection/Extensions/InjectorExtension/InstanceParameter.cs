using System;
using System.Reflection;

namespace Blacklite.Shared.Reflection.Extensions.InjectorExtension
{
    class InstanceParameter : ConfiguredParameter
    {
        internal InstanceParameter(ParameterInfo parameterInfo, bool optional)
            : base(parameterInfo, optional)
        {
        }

        internal InstanceParameter(Type desiredType, Func<Type, Func<ParameterInfo, bool>> predicate, bool optional = false)
            : base(null, optional)
        {
            TypeInfo = desiredType?.GetTypeInfo();
            Predicate = predicate;
        }

        public TypeInfo TypeInfo { get; }
        public Func<Type, Func<ParameterInfo, bool>> Predicate { get; }
    }
}
