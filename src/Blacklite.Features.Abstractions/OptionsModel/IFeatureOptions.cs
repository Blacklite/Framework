// ReSharper disable CheckNamespace

namespace Blacklite.Features.OptionsModel
{
    public interface IFeatureOptions
    {
        void SetOptions(object options);
    }

    public interface IFeatureOptions<out TOptions>
        where TOptions : class, new()
    {
        TOptions Options { get; }
    }
}
