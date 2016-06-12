using System;
// ReSharper disable CheckNamespace

namespace Blacklite.Features
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class FeatureDescriptionAttribute : Attribute
    {
        public string Description { get; }
        public FeatureDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
