using Blacklite.Features.Composition;
using Blacklite.Features.Describers;
using Blacklite.Features.Observables;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Features.Factory
{
    public class FeatureFactory : IFeatureFactory
    {
        protected readonly IFeatureCompositionProvider FeatureCompositionProvider;
        private readonly IFeatureDescriberProvider _featureDescriberProvider;
        private readonly ConcurrentDictionary<Type, IFeature> _features = new ConcurrentDictionary<Type, IFeature>();

        public FeatureFactory(
            IFeatureCompositionProvider featureCompositionProvider,
            IFeatureDescriberProvider featureDescriberProvider)
        {
            FeatureCompositionProvider = featureCompositionProvider;
            _featureDescriberProvider = featureDescriberProvider;
        }

        public IFeature GetFeature(Type featureType)
        {
            var describer = _featureDescriberProvider.Describers[featureType];

            if (describer.IsObservable)
                return Compose(featureType, describer);

            return _features.GetOrAdd(featureType, x => Compose(featureType, describer));
        }

        private IFeature Compose(Type featureType, IFeatureDescriber describer)
        {
            return (IFeature)GetComposers(featureType)
                .Aggregate(Activator.CreateInstance(featureType), (feature, setup) => setup.Configure(feature, describer, this));
        }

        protected virtual IEnumerable<IFeatureComposition> GetComposers(Type featureType)
        {
            return FeatureCompositionProvider.GetComposers(featureType);
        }
    }
}
