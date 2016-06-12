using System;
using System.Reflection;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Describers
{
    public interface IFeatureOptionsDescriber
    {
        Type Type { get; }
        TypeInfo TypeInfo { get; }
        string DisplayName { get; }
        string Description { get; }
        bool IsFeature { get; }
        bool IsSwitch { get; }
    }
}
