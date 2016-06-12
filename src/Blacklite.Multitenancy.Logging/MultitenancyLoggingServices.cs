using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Multitenancy
{
    public static class MultitenancyLoggingServices
    {
        public static IEnumerable<ServiceDescriptor> GetDefaultServices()
        {
            yield return TenantOnlyServiceDescriptor.Singleton<ITenantLogger, TenantLogger>();
            yield return ApplicationOnlyServiceDescriptor.Singleton<IApplicationLogger, ApplicationLogger>();
        }
    }
}
