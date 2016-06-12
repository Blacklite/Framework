using Blacklite;
using Blacklite;
using Blacklite.Multitenancy.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Hosting.Internal;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BlackliteMultitenancyHttpServiceCollectionExtensions
    {
        public static IServiceCollection AddHttpMultitenancy([NotNull] this IServiceCollection services)
        {
            services.AddMultitenancy()
                    .TryAdd(BlackliteMultitenancyHttpServices.GetDefaultServices());

            var autoRequestServices = services.FirstOrDefault(x => x.ImplementationType == typeof(AutoRequestServicesStartupFilter));
            if (autoRequestServices != null)
            {
                services.Remove(autoRequestServices);
            }

            return services;
        }
    }
}
