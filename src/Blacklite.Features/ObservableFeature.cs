using Blacklite.Features.Describers;
using Blacklite.Features.Observables;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reactive.Subjects;

namespace Blacklite.Features
{
    public abstract class ObservableFeature : Feature, IObservableFeature { }

    class ObservableFeatureImpl<T> : ObservableFeature<T>
        where T : class, IObservableFeature, new()
    {
        private readonly IFeatureSubject<T> _feature;
        public ObservableFeatureImpl(IFeatureSubjectFactory factory)
        {
            _feature = (IFeatureSubject<T>)factory.GetSubject(typeof(T));
        }

        public T Value => _feature.Value;

        public IDisposable Subscribe(IObserver<T> observer) => _feature.Subscribe(observer);
    }
}
