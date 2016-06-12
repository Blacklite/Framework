using System;
// ReSharper disable CheckNamespace

namespace Blacklite.Features
{
    // ReSharper disable once InconsistentNaming
    public interface ObservableFeature<out T> : IObservable<T>
        where T : IObservableFeature
    {
        T Value { get; }
    }
}
