using Blacklite.Features.Describers;
using Blacklite.Features.Observables;
using Blacklite.Multitenancy.Features;
using Blacklite.Multitenancy.Features.Describers;
using Blacklite.Multitenancy.Features.Observables;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Features
{
    public static class BlackliteMultitenancyFeaturesServices
    {
        internal static IEnumerable<ServiceDescriptor> GetMultitenancyFeatures()
        {
            yield return ServiceDescriptor.Singleton<IFeatureDescriberFactory, MultitenancyFeatureDescriberFactory>();
            yield return ServiceDescriptor.Singleton<IApplicationOnlyFeatureSubjectFactory, ApplicationOnlyFeatureSubjectFactory>();
            yield return ServiceDescriptor.Singleton<ITenantOnlyFeatureSubjectFactory, TenantOnlyFeatureSubjectFactory>();
            yield return ServiceDescriptor.Singleton<IFeatureSubjectFactory, MultitenancyCompositeFeatureSubjectFactory>();
        }
    }
}
