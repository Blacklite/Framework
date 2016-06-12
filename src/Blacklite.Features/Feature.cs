using System;
using Blacklite.Features.Factory;

namespace Blacklite.Features
{
    public abstract partial class Feature : IFeature { }

    public class FeatureImpl<TFeature> : Feature<TFeature>
        where TFeature : class, new()
    {
        private readonly IFeatureFactory _factory;
        private object _lock = new object();
        private readonly Lazy<TFeature> _value;

        public FeatureImpl(IFeatureFactory factory)
        {
            _factory = factory;
            _value = new Lazy<TFeature>(Configure);
        }
        public TFeature Value => _value.Value;

        public virtual TFeature Configure()
        {
            return _factory.GetFeature<TFeature>();
        }
    }
}
