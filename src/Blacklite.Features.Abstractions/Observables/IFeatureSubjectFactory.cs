using System;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Observables
{
    public interface IFeatureSubjectFactory
    {
        IFeatureSubject GetSubject(Type featureType);
    }

    public interface ISingletonFeatureSubjectFactory : IFeatureSubjectFactory { }
}
