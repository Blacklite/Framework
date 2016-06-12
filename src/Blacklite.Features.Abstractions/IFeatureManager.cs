using Blacklite.Features.Describers;
// ReSharper disable CheckNamespace

namespace Blacklite.Features
{
    public interface IFeatureManager
    {
        bool TrySaveFeature(IFeatureDescriber describer, IFeature feature);
    }
}
