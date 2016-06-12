using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Blacklite.Multitenancy.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Blacklite.Multitenancy.Events;

namespace Blacklite.Multitenancy
{
    public static class BlackliteMultitenancyServices
    {
        public static IEnumerable<ServiceDescriptor> GetDefaultServices()
        {
            yield return ApplicationOnlyServiceDescriptor.Singleton<ITenantConfigurationService, TenantConfigurationService>();
            yield return ApplicationOnlyServiceDescriptor.Singleton<ITenantRegistry, DefaultTenantRegistry>();
        }

        public static IEnumerable<ServiceDescriptor> GetCollectionServices()
        {
            yield return ServiceDescriptor.Transient<ITenantComposer, EventsBroadcastComposer>();
        }
    }
}
