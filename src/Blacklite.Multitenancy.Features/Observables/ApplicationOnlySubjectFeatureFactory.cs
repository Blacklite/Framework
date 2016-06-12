using Blacklite.Features;
using Blacklite.Features.Describers;
using Blacklite.Features.Observables;
using System;

namespace Blacklite.Multitenancy.Features.Observables
{
    public interface IApplicationOnlyFeatureSubjectFactory : IFeatureSubjectFactory { }
    public class ApplicationOnlyFeatureSubjectFactory : IApplicationOnlyFeatureSubjectFactory
    {
        private readonly IFeatureSubjectFactory _factory;

        public ApplicationOnlyFeatureSubjectFactory(IServiceProvider serviceProvider)
        {
            _factory = new FeatureSubjectFactory(serviceProvider);
        }

        public IFeatureSubject GetSubject(Type featureType)
        {
            return _factory.GetSubject(featureType);
        }
    }
}
