using Blacklite.Multitenancy.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Multitenancy.Http
{
    public static class BlackliteMultitenancyHttpServices
    {
        public static IEnumerable<ServiceDescriptor> GetDefaultServices()
        {
            return Enumerable.Empty<ServiceDescriptor>();
        }
    }
}
