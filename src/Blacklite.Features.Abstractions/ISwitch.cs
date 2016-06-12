using Blacklite.Features.OptionsModel;
// ReSharper disable CheckNamespace

namespace Blacklite.Features
{
    public interface ISwitch : IFeature
    {
        [Display(Name = "On")]
        bool IsEnabled { get; }
    }

    public interface ISwitch<TOptions> : ISwitch, IFeatureOptions
        where TOptions : class, new()
    {
        TOptions Options { get; }
    }
}
