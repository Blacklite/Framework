using Blacklite.Features.Composition;
using Blacklite.Features.Describers;
using Blacklite.Features.Factory;
using Blacklite.Features.Observables;
using Blacklite.Features.OptionsModel;
using Blacklite.Features.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Features
{
    public static class BlackliteFeaturesServices
    {
        internal static IEnumerable<ServiceDescriptor> GetFeatures(IServiceCollection services)
        {
            yield return ServiceDescriptor.Singleton<IFeatureDescriberProvider, FeatureDescriberProvider>();
            yield return ServiceDescriptor.Singleton<IFeatureDescriberFactory, FeatureDescriberFactory>();
            yield return ServiceDescriptor.Singleton<IFeatureAssemblyProvider, FeatureAssemblyProvider>();
            yield return ServiceDescriptor.Singleton<IFeatureTypeProvider, FeatureTypeProvider>();
            yield return ServiceDescriptor.Singleton<IFeatureCompositionProvider, FeatureCompositionProvider>();
            yield return ServiceDescriptor.Singleton<IFeatureOptionsProvider, FeatureOptionsProvider>();
            yield return ServiceDescriptor.Scoped<IFeatureManager, FeatureManager>();

            yield return ServiceDescriptor.Scoped<IFeatureFactory, FeatureFactory>();

            yield return ServiceDescriptor.Scoped<IFeatureSubjectFactory, CompositeFeatureSubjectFactory>();
            yield return ServiceDescriptor.Singleton<ISingletonFeatureSubjectFactory, SingletonFeatureSubjectFactory>();

            yield return ServiceDescriptor.Scoped(typeof(Feature<>), typeof(FeatureImpl<>));
            yield return ServiceDescriptor.Scoped(typeof(IFeatureSubject<>), typeof(FeatureSubject<>));
            yield return ServiceDescriptor.Scoped(typeof(ObservableFeature<>), typeof(ObservableFeatureImpl<>));
            yield return ServiceDescriptor.Singleton<IObservableFeatureFactory, ObservableFeatureFactory>();

            yield return ServiceDescriptor.Singleton<IRequiredFeaturesService, RequiredFeaturesService>();
            yield return ServiceDescriptor.Singleton(typeof(IFeatureOptions<>), typeof(FeatureOptionsManager<>));

            yield return ServiceDescriptor.Transient<FeatureDescriberCollection, FeatureDescriberCollection>();
            yield return ServiceDescriptor.Singleton<IFeatureRepositoryProvider, FeatureRepositoryProvider>();
        }

        internal static IEnumerable<ServiceDescriptor> GetEnumerableFeatures()
        {
            yield return ServiceDescriptor.Transient<IPreFeatureComposition, OptionsFeatureComposer>();
            yield return ServiceDescriptor.Transient<IPostFeatureComposition, RequiredFeatureComposer>();
        }

        internal static IEnumerable<ServiceDescriptor> GetFeaturesConfiguration(IConfiguration configuration, Func<IFeatureDescriber, bool> predicate = null)
        {
            if (predicate == null)
            {
                yield return ServiceDescriptor.Singleton<IFeatureComposition>(new ConfigurationFeatureComposer(configuration));
                yield return ServiceDescriptor.Singleton<IFeatureRepository>(new ConfigurationFeatureRepository(configuration));
            }
            else
            {
                yield return ServiceDescriptor.Singleton<IFeatureComposition>(new ConfigurationFeatureComposer(configuration, predicate));
                yield return ServiceDescriptor.Singleton<IFeatureRepository>(new ConfigurationFeatureRepository(configuration, predicate));
            }
        }

        internal static IEnumerable<ServiceDescriptor> GetFeaturesOptions()
        {
            yield return ServiceDescriptor.Transient<IPreFeatureComposition, OptionsFeatureComposer>();
        }

        internal static IEnumerable<ServiceDescriptor> GetFeaturesRequired()
        {
            yield return ServiceDescriptor.Transient<IPostFeatureComposition, RequiredFeatureComposer>();
        }
    }
}
