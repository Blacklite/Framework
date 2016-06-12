using Microsoft.Extensions.DependencyInjection;
using Blacklite.Features.OptionsModel;
using System;
using System.Linq;
using System.Reflection;
using Blacklite.Features.Describers;
using Blacklite.Features.Factory;

namespace Blacklite.Features.Composition
{
    public class OptionsFeatureComposer : IFeatureComposition, IPreFeatureComposition
    {
        private readonly IServiceProvider _serviceProvider;
        public OptionsFeatureComposer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public int Priority { get; } = int.MaxValue;

        public T Configure<T>(T feature, IFeatureDescriber describer, IFeatureFactory factory)
        {
            var traitOptions = feature as IFeatureOptions;
            if (traitOptions != null)
            {
                object options;
                if (typeof(IFeature).GetTypeInfo().IsAssignableFrom(describer.Options.TypeInfo))
                {
                    options = factory.GetFeature(describer.Options.Type);
                }
                else
                {
                    var optionsType = typeof(IFeatureOptions<>).MakeGenericType(describer.Options.Type);
                    options = ((IFeatureOptions<object>)_serviceProvider.GetService(optionsType)).Options;
                }
                traitOptions.SetOptions(options);
            }

            return feature;
        }

        public bool IsApplicableTo(IFeatureDescriber describer)
        {
            return describer.HasOptions;
        }
    }
}
