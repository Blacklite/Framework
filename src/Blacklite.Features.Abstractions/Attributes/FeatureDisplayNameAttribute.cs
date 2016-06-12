using System;
// ReSharper disable CheckNamespace

namespace Blacklite.Features
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class FeatureDisplayNameAttribute : Attribute
    {
        public string DisplayName { get; }
        public FeatureDisplayNameAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }
}
