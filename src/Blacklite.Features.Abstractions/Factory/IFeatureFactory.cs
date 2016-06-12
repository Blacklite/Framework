using System;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Factory
{
    public interface IFeatureFactory
    {
        IFeature GetFeature(Type featureType);
    }
}
