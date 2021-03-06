﻿using Blacklite.Features.Describers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reflection;

namespace Blacklite.Features
{
    class RequiredFeaturesService : IRequiredFeaturesService
    {
        private readonly IFeatureDescriberProvider _provider;
        private readonly IServiceProvider _serviceProvider;

        public RequiredFeaturesService(IServiceProvider serviceProvider, IFeatureDescriberProvider provider)
        {
            _provider = provider;
            _serviceProvider = serviceProvider;
        }

        private object GetRequiredFeature(IFeatureDescriber describer)
        {
            if (describer.IsObservable)
                return _serviceProvider.GetRequiredService(typeof(ObservableFeature<>).MakeGenericType(describer.Type));

            return _serviceProvider.GetRequiredService(typeof(Feature<>).MakeGenericType(describer.Type));
        }

        private IEnumerable<FeatureDependency> GetFeatureDependencies(IFeatureDescriber describer)
        {
            return describer.DependsOn
                .Where(x => x.Key.HasEnabled)
                .Select(x =>
                new FeatureDependency()
                {
                    Service = GetRequiredFeature(x.Key),
                    FeatureType = x.Key.Type,
                    IsObservable = x.Key.IsObservable,
                    ShouldBeEnabled = x.Value
                });
        }

        private static IEnumerable<SimpleFeatureWrapper> GetSimpleFeatures(IEnumerable<FeatureDependency> featureDependencies)
        {
            return featureDependencies
                .Where(x => !x.IsObservable)
                .Select(SimpleFeatureWrapper.CreateWrapper);
        }

        private static IEnumerable<ObservableFeatureWrapper> GetObservableFeatures(IEnumerable<FeatureDependency> featureDependencies)
        {
            return featureDependencies
                .Where(x => x.IsObservable)
                .Select(ObservableFeatureWrapper.CreateWrapper);
        }

        public bool ValidateRequiredFeatures(Type type)
        {
            var featureDependencies = GetFeatureDependencies(_provider.Describers[type]).ToArray();
            var simpleFeatures = GetSimpleFeatures(featureDependencies).ToArray();
            var observableFeatures = GetObservableFeatures(featureDependencies).ToArray();

            if (observableFeatures.Any())
            {
                var result = simpleFeatures.All(z => z.IsEnabled == z.ShouldBeEnabled);
                if (result)
                {
                    result = observableFeatures.All(z => z.IsEnabledMethod() == z.ShouldBeEnabled);
                }

                foreach (var disposable in observableFeatures.Select(x => x.Disposable))
                    disposable.Dispose();

                return result;
            }

            if (simpleFeatures.Any())
            {
                return simpleFeatures.All(z => z.IsEnabled == z.ShouldBeEnabled);
            }

            return true;
        }

        public IObservable<bool> GetObservableRequiredFeatures(Type type)
        {
            var featureDependencies = GetFeatureDependencies(_provider.Describers[type]).ToArray();
            var simpleFeatures = GetSimpleFeatures(featureDependencies).ToArray();
            var observableFeatures = featureDependencies
                .Where(x => x.IsObservable)
                .Select(EnabledObservableWrapper.CreateWrapper)
                .ToArray();

            if (!observableFeatures.Any()) return Observable.Empty<bool>();

            var allNonObservableFeaturesAreValid = simpleFeatures
                .All(z => z.IsEnabled == z.ShouldBeEnabled);

            if (allNonObservableFeaturesAreValid)
            {
                return Observable.Merge(observableFeatures);
            }

            return Observable.Empty<bool>();
        }

        private class FeatureDependency
        {
            public object Service { get; set; }
            public Type FeatureType { get; set; }
            public bool IsObservable { get; set; }
            public bool ShouldBeEnabled { get; set; }
        }

        private class SimpleFeatureWrapper
        {
            public static SimpleFeatureWrapper CreateWrapper(FeatureDependency dependency)
            {
                return new SimpleFeatureWrapper()
                {
                    IsEnabled = GetTrait(dependency).IsEnabled,
                    ShouldBeEnabled = dependency.ShouldBeEnabled
                };
            }

            private static ISwitch GetTrait(FeatureDependency dependency)
            {
                var property = typeof(Feature<object>).GetTypeInfo().GetDeclaredProperty(nameof(Feature<object>.Value));
                return (ISwitch)property.GetValue(dependency.Service, null);
            }

            public bool IsEnabled { get; set; }
            public bool ShouldBeEnabled { get; set; }
        }

        private class ObservableFeatureWrapper
        {
            public static ObservableFeatureWrapper CreateWrapper(FeatureDependency dependency)
            {
                var tuple = InvokeSubscribeToObservableMethod(dependency);
                return new ObservableFeatureWrapper()
                {
                    ShouldBeEnabled = dependency.ShouldBeEnabled,
                    IsEnabledMethod = tuple.Item1,
                    IsEnabledObservable = tuple.Item3,
                    Disposable = tuple.Item2
                };
            }

            private static readonly MethodInfo SubscribeToObservableMethod = typeof(ObservableFeatureWrapper).GetTypeInfo()
                .GetDeclaredMethod(nameof(SubscribeToObservable));

            private static readonly ConcurrentDictionary<Type, MethodInfo> Methods = new ConcurrentDictionary<Type, MethodInfo>();

            private static Tuple<Func<bool>, IDisposable, IObservable<bool>> InvokeSubscribeToObservableMethod(FeatureDependency dependency)
            {
                return (Tuple<Func<bool>, IDisposable, IObservable<bool>>)Methods.GetOrAdd(dependency.FeatureType, x =>
                {
                    var observableFeatureType = typeof(ObservableFeature<>).MakeGenericType(dependency.FeatureType);
                    return SubscribeToObservableMethod.MakeGenericMethod(observableFeatureType, dependency.FeatureType);
                }).Invoke(null, new object[] { dependency.Service });
            }

            private static Tuple<Func<bool>, IDisposable, IObservable<bool>> SubscribeToObservable<TObservable, TFeature>(TObservable observable)
                where TObservable : ObservableFeature<TFeature>
                where TFeature : IObservableSwitch
            {
                var enabled = false;
                // We can do this and be comfortable that our enabled flag will be populated because ObservableFeatures are powered by a behavior subject.
                var disposable = observable.Subscribe(x => enabled = x.IsEnabled);
                var boolObservable = observable.Select(x => x.IsEnabled);
                return new Tuple<Func<bool>, IDisposable, IObservable<bool>>(() => enabled, disposable, boolObservable);
            }

            public bool ShouldBeEnabled { get; set; }
            public Func<bool> IsEnabledMethod { get; set; }
            public IObservable<bool> IsEnabledObservable { get; set; }
            public IDisposable Disposable { get; set; }
        }

        private class EnabledObservableWrapper
        {
            public static IObservable<bool> CreateWrapper(FeatureDependency dependency)
            {
                return InvokeSubscribeToObservableMethod(dependency);
            }

            private static readonly MethodInfo SubscribeToObservableMethod = typeof(EnabledObservableWrapper).GetTypeInfo()
                .GetDeclaredMethod(nameof(SubscribeToObservable));

            private static readonly ConcurrentDictionary<Type, MethodInfo> Methods = new ConcurrentDictionary<Type, MethodInfo>();

            private static IObservable<bool> InvokeSubscribeToObservableMethod(FeatureDependency dependency)
            {
                return (IObservable<bool>)Methods.GetOrAdd(dependency.FeatureType, x =>
                {
                    var observableFeatureType = typeof(ObservableFeature<>).MakeGenericType(dependency.FeatureType);
                    return SubscribeToObservableMethod.MakeGenericMethod(observableFeatureType, dependency.FeatureType);
                }).Invoke(null, new object[] { dependency.Service });
            }

            private static IObservable<bool> SubscribeToObservable<TObservable, TFeature>(TObservable observable)
                where TObservable : ObservableFeature<TFeature>
                where TFeature : IObservableSwitch
            {
                var boolObservable = observable.Select(x => x.IsEnabled);
                return boolObservable;
            }

            public IObservable<bool> Observable { get; set; }
        }
    }
}
