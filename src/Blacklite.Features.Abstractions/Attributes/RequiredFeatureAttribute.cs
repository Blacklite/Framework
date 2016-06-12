using System;
using System.Reflection;
// ReSharper disable CheckNamespace

namespace Blacklite.Features
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class RequiredFeatureAttribute : Attribute
    {
        public TypeInfo FeatureType { get; }
        public bool IsEnabled { get; }
        public RequiredFeatureAttribute(Type featureType, bool isEnabled = true)
        {
            FeatureType = featureType.GetTypeInfo();
            IsEnabled = isEnabled;
        }
    }
}
