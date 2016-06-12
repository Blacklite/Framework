using Blacklite.Features.Describers;
using Blacklite.Features.Factory;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Composition
{
    public interface IFeatureComposition
    {
        int Priority { get; }
        bool IsApplicableTo(IFeatureDescriber describer);
        T Configure<T>(T feature, IFeatureDescriber describer, IFeatureFactory factory);
    }

    public interface IPreFeatureComposition : IFeatureComposition { }

    public interface IPostFeatureComposition : IFeatureComposition { }
}
