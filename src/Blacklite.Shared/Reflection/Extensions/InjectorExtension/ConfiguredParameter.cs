using System;
using System.Reflection;

namespace Blacklite.Shared.Reflection.Extensions.InjectorExtension
{
    internal class ConfiguredParameter
    {
        internal ConfiguredParameter(ParameterInfo parameterInfo, bool optional)
        {
            ParameterInfo = parameterInfo;
            Optional = optional;
        }

        public ParameterInfo ParameterInfo { get; }

        public bool Optional { get; }
    }
}
