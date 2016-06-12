using System;
// ReSharper disable CheckNamespace

namespace Blacklite.Features
{
    public interface IRequiredFeaturesService
    {
        bool ValidateRequiredFeatures(Type type);

        IObservable<bool> GetObservableRequiredFeatures(Type type);
    }
}
