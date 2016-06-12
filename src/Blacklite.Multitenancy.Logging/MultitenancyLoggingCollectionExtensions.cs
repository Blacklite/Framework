using Blacklite;
using Blacklite;
using Blacklite.Multitenancy;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MultitenancyLoggingCollectionExtensions
    {
        public static IServiceCollection AddMultitenancyLogging([NotNull] this IServiceCollection services)
        {
            services.Add(MultitenancyLoggingServices.GetDefaultServices());
            return services;
        }
    }
}
