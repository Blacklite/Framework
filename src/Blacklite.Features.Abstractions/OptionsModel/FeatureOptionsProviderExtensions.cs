using System;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.OptionsModel
{
    public static class FeatureOptionsProviderExtensions
    {
        public static TOptions GetOptions<TOptions>(this IFeatureOptionsProvider provider)
            where TOptions : class, new()
        {
            return (TOptions)provider.GetOptions(typeof(TOptions));
        }
    }
}
