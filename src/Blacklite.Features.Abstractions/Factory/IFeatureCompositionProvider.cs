using Blacklite.Features.Composition;
using System;
using System.Collections.Generic;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Factory
{
    public interface IFeatureCompositionProvider
    {
        IEnumerable<IFeatureComposition> GetComposers<TFeature>()
            where TFeature : class, new();
    }
}
