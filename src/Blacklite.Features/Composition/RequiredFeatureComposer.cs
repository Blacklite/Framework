﻿using Blacklite.Features.Describers;
using Blacklite.Features.Factory;
using Blacklite.Features.OptionsModel;
using System;
using System.Linq;
using System.Reflection;

namespace Blacklite.Features.Composition
{
    public class RequiredFeatureComposer : IFeatureComposition, IPostFeatureComposition
    {
        private readonly IRequiredFeaturesService _requiredFeatures;
        public RequiredFeatureComposer(IRequiredFeaturesService requiredFeatures)
        {
            _requiredFeatures = requiredFeatures;
        }

        public int Priority { get; } = 0;

        public T Configure<T>(T feature, IFeatureDescriber describer, IFeatureFactory factory)
        {
            var trait = feature as ISwitch;

            var value = _requiredFeatures.ValidateRequiredFeatures(describer.Type);
            describer.SetIsEnabled(feature, trait.IsEnabled && value);

            return feature;
        }

        public bool IsApplicableTo(IFeatureDescriber describer)
        {
            return describer.HasEnabled && !describer.IsReadOnly && describer.Requires.Any();
        }
    }
}
