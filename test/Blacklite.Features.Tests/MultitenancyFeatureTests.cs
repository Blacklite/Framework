using Blacklite.Features;
using Blacklite.Multitenancy;
using Blacklite.Multitenancy.Features;
using Blacklite.Multitenancy.Features.Describers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Multitenancy.Tests
{
    public class MultitenancyFeatureTests
    {
        class ScopedFeature : Feature
        {
        }

        class SingletonFeature : Feature
        {
        }


        [RequiredFeature(typeof(SingletonFeature)), TenantOnly]
        class TenantFeature : Feature
        {
        }

        [RequiredFeature(typeof(SingletonFeature)), ApplicationOnly]
        class ApplicationFeature : Feature
        {
        }


        [RequiredFeature(typeof(ScopedFeature)), TenantOnly]
        class InvalidTenantFeature : Feature
        {
        }

        [RequiredFeature(typeof(ScopedFeature)), ApplicationOnly]
        class InvalidApplicationFeature : Feature
        {
        }

        [Fact]
        public void SingletonTenantThrowsForInvalidDescriptor()
        {
            var servicesCollection = new[] {
            typeof(ScopedFeature),
            typeof(SingletonFeature),
            typeof(TenantFeature),
            typeof(InvalidTenantFeature),
            }.Select(x => x.GetTypeInfo());

            var describers = new MultitenancyFeatureDescriberFactory().Create(servicesCollection).Cast<MultitenancyFeatureDescriber>();
            var describer = describers.First(x => x.Type == typeof(SingletonFeature));

            Assert.Throws<NotSupportedException>(() => describers.First(x => x.Type == typeof(InvalidTenantFeature)));
        }

        [Fact]
        public void SingletonApplicationThrowsForInvalidDescriptor()
        {
            var servicesCollection = new[] {
            typeof(ScopedFeature),
            typeof(SingletonFeature),
            typeof(ApplicationFeature),
            typeof(InvalidApplicationFeature),
            }.Select(x => x.GetTypeInfo());

            var describers = new MultitenancyFeatureDescriberFactory().Create(servicesCollection).Cast<MultitenancyFeatureDescriber>();
            var describer = describers.First(x => x.Type == typeof(SingletonFeature));

            Assert.Throws<NotSupportedException>(() => describers.First(x => x.Type == typeof(InvalidApplicationFeature)));
        }
    }
}
