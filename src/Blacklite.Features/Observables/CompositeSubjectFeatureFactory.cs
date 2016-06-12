using Blacklite.Features.Describers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Blacklite.Features.Observables
{
    public class CompositeFeatureSubjectFactory : IFeatureSubjectFactory
    {
        private readonly ISingletonFeatureSubjectFactory _singletonFeatureFactory;
        private readonly IFeatureDescriberProvider _describerProvider;

        public CompositeFeatureSubjectFactory(
            ISingletonFeatureSubjectFactory singletonFeatureFactory,
            IFeatureDescriberProvider describerProvider)
        {
            _singletonFeatureFactory = singletonFeatureFactory;
            _describerProvider = describerProvider;
        }

        public virtual IFeatureSubject GetSubject(Type featureType)
        {
            // this allows multi-tenancy to inject it's own provider for tenant based subjects
            return _singletonFeatureFactory.GetSubject(featureType);
        }
    }
}
