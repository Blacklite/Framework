using Blacklite.Features;
using Blacklite.Features.Describers;
using Blacklite.Features.Observables;
using System;

namespace Blacklite.Multitenancy.Features.Observables
{
    public interface ITenantOnlyFeatureSubjectFactory : IFeatureSubjectFactory { }
    public class TenantOnlyFeatureSubjectFactory : ITenantOnlyFeatureSubjectFactory
    {
        private readonly IFeatureSubjectFactory _factory;

        public TenantOnlyFeatureSubjectFactory(IServiceProvider serviceProvider)
        {
            _factory = new FeatureSubjectFactory(serviceProvider);
        }

        public IFeatureSubject GetSubject(Type featureType)
        {
            return _factory.GetSubject(featureType);
        }
    }
}
