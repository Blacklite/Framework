using Blacklite.Features.Describers;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Repositories
{
    public interface IFeatureRepository
    {
        int Priority { get; }

        bool IsApplicableTo(IFeatureDescriber describer);

        void Store(IFeature feature, IFeatureDescriber describer);
    }
}
