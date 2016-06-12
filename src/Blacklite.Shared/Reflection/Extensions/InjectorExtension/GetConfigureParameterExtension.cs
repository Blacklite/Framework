using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Shared.Reflection.Extensions.InjectorExtension
{
    internal static class GetConfigureParameterExtension
    {
        internal static ConfiguredParameter GetConfigureParameter(this IDictionary<TypeInfo, ConfiguredParameter> resolvedConfiguredParameter, Type type, IEnumerable<ConfiguredParameter> configuredParameters)
        {
            var typeInfo = type?.GetTypeInfo();
            ConfiguredParameter configuredParam = null;
            if (typeInfo != null && !resolvedConfiguredParameter.TryGetValue(typeInfo, out configuredParam))
            {
                configuredParam = configuredParameters.SingleOrDefault(x => type != typeof(object) && x.ParameterInfo.ParameterType != typeof(object) && x.ParameterInfo.ParameterType.GetTypeInfo().IsAssignableFrom(typeInfo) || typeInfo == x.ParameterInfo.ParameterType.GetTypeInfo());
                resolvedConfiguredParameter.Add(typeInfo, configuredParam);
            }

            return configuredParam;
        }
    }
}
