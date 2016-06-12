using System;
using System.Reflection;
// ReSharper disable CheckNamespace

namespace Blacklite.Features
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ParentFeatureAttribute : Attribute
    {
        public TypeInfo Feature { get; }
        public ParentFeatureAttribute(Type featureType)
        {
            Feature = featureType.GetTypeInfo();
        }
    }
}
