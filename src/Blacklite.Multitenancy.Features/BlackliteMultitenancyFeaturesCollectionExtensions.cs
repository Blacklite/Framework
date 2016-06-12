using Blacklite;
using Blacklite;
using Blacklite.Features;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BlackliteMultitenancyFeaturesCollectionExtensions
    {
        public static IServiceCollection AddMultitenancyFeatures([NotNull] this IServiceCollection services)
        {
            services.AddFeatures()
                    .AddMultitenancy()
                    .Add(BlackliteMultitenancyFeaturesServices.GetMultitenancyFeatures());

            return services;
        }
    }
}
