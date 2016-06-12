using System;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Observables
{

    public interface IObservableFeatureFactory
    {
        ObservableFeature<T> GetObservableFeature<T>()
            where T : class, IObservableFeature, new();
    }
}
