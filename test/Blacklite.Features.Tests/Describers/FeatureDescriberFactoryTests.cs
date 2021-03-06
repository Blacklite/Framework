﻿using Blacklite.Features;
using Blacklite.Features.Describers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Features.Tests
{
    public class FeatureDescriberFactoryTests
    {
        [RequiredFeature(typeof(SingletonFeature))]
        [RequiredFeature(typeof(RealObservableSwitch))]
        class ScopedFeature : Switch
        {
        }

        [RequiredFeature(typeof(RealObservableSwitch))]
        class SingletonFeature : Switch
        {
        }

        class RealObservableSwitch : ObservableSwitch
        {
        }

        class RealObservableSwitch2 : ObservableSwitch
        {
        }

        [RequiredFeature(typeof(ScopedFeature))]
        class InvalidRealObservableSwitch : ObservableSwitch
        {
        }

        [Fact]
        public void ObservableThrowsForInvalidDescriptor()
        {
            var servicesCollection = new[] {
            typeof(ScopedFeature),
            typeof(SingletonFeature),
            typeof(RealObservableSwitch),
            typeof(RealObservableSwitch2),
            typeof(InvalidRealObservableSwitch),
            }.Select(x => x.GetTypeInfo());
            var describers = new FeatureDescriberFactory().Create(servicesCollection).Cast<FeatureDescriber>();

            var describer = describers.First(x => x.Type == typeof(RealObservableSwitch));
            FeatureDescriberFactory.ValidateDescriber(describer);

            describer = describers.First(x => x.Type == typeof(RealObservableSwitch2));
            FeatureDescriberFactory.ValidateDescriber(describer);

            Assert.Throws<NotSupportedException>(() => describers.First(x => x.Type == typeof(InvalidRealObservableSwitch)));
        }
    }
}
