using Blacklite;
using Blacklite.Features.Editors;
using Blacklite.Features.Http.Extensions;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.FileProviders;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.StaticFiles;
using System;
using Microsoft.Extensions.DependencyInjection;
using Blacklite.Features.Describers;

namespace Microsoft.AspNet.Builder
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseFeaturesHttp([NotNull] this IApplicationBuilder builder, string pathMatch,
            IFeatureEditorFactory factory = null)
        {
            return UseFeaturesHttp(builder, new PathString(pathMatch), factory);
        }

        public static IApplicationBuilder UseFeaturesHttp([NotNull] this IApplicationBuilder builder, PathString pathMatch,
            IFeatureEditorFactory factory = null)
        {
            return builder
                .Map(pathMatch, b => b.UseFeaturesHttp(new FeatureOptions(pathMatch.Value)
                {
                    Factory = factory,
                    Path = pathMatch.Value
                }));
        }

        public static IApplicationBuilder UseFeaturesHttp([NotNull] this IApplicationBuilder builder, string pathMatch,
            [NotNull] Func<IApplicationBuilder, IApplicationBuilder> configuration, IFeatureEditorFactory factory = null)
        {
            return UseFeaturesHttp(builder, new PathString(pathMatch), configuration, factory);
        }

        public static IApplicationBuilder UseFeaturesHttp([NotNull] this IApplicationBuilder builder, PathString pathMatch,
            [NotNull] Func<IApplicationBuilder, IApplicationBuilder> configuration, IFeatureEditorFactory factory = null)
        {
            return builder
                .Map(pathMatch, b => configuration(b).UseFeaturesHttp(new FeatureOptions(pathMatch.Value)
                {
                    Factory = factory,
                    Path = pathMatch.Value
                }));
        }

        public static IApplicationBuilder UseFeaturesHttp([NotNull] this IApplicationBuilder builder,
            [NotNull] Func<IApplicationBuilder, IApplicationBuilder> configuration, FeatureOptions options)
        {
            return configuration(builder).UseFeaturesHttp(options);
        }

        public static IApplicationBuilder UseFeaturesHttp([NotNull] this IApplicationBuilder builder, FeatureOptions options)
        {
            if (options.Factory == null)
            {
                options.Factory = builder.ApplicationServices.GetService<FeatureEditorFactory<FeatureDescriberCollection>>();
            }

            return builder
                .UseStaticFiles(new StaticFileOptions()
                {
                    FileProvider = options.FileProvider
                })
                .UseMiddleware<FeatureMiddleware>(options);
        }
    }
}
