using Blacklite;
using Blacklite;
using Blacklite.Features;
using Blacklite.Features.Describers;
using Blacklite.Features.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BlackliteFeaturesMvcCollectionExtensions
    {
        public static IServiceCollection AddFeaturesHttp([NotNull] this IServiceCollection services)
        {
            services.AddFeatureEditorModel()
                    .AddDataProtection()
                    .AddAntiforgery();
            services.TryAdd(BlackliteFeaturesHttpServices.GetFeaturesHttp(services));
            return services;
        }
    }
}
