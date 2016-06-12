using System;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.OptionsModel
{
    public interface IConfigureFeatureOptions
    {
        int Priority { get; }
        void Configure(object options);
    }

    public interface IConfigureFeatureOptions<in TOptions>
        where TOptions : class, new()
    {
        int Priority { get; }
        void Configure(TOptions options);
    }
}
