using Blacklite;
using Blacklite;
using Blacklite.Multitenancy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BlackliteMultitenancyServiceCollectionExtensions
    {
        public static IServiceCollection AddMultitenancy([NotNull] this IServiceCollection services)
        {
            services.TryAdd(BlackliteMultitenancyServices.GetDefaultServices());
            services.TryAddImplementation(BlackliteMultitenancyServices.GetCollectionServices());
            return services;
        }
    }
}
