using Blacklite.Features.Describers;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Repositories
{
    public interface IFeatureRepositoryProvider
    {
        IFeatureRepository GetFeatureRepository(IFeatureDescriber describer);
    }
}
