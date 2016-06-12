using System;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.OptionsModel
{
    public interface IFeatureOptionsProvider
    {
        object GetOptions(Type optionsType);
    }
}
