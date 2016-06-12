using System;
using System.Collections.Generic;
using System.Reflection;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Describers
{
    public interface IFeatureDescriber
    {
        Type Type { get; }
        TypeInfo TypeInfo { get; }
        bool IsObservable { get; }
        bool HasEnabled { get; }
        bool HasOptions { get; }
        IEnumerable<IFeaturePropertyDescriber> Properties { get; }
        IFeatureOptionsDescriber Options { get; }
        bool IsReadOnly { get; }
        string DisplayName { get; }
        string Description { get; }
        IReadOnlyDictionary<IFeatureDescriber, bool> DependsOn { get; }
        IEnumerable<IFeatureDescriber> Children { get; }
        IEnumerable<string> Groups { get; }

        IEnumerable<RequiredFeatureAttribute> Requires { get; }
        TypeInfo Parent { get; }

        T GetIsEnabled<T>(object instance);
        void SetIsEnabled<T>(object instance, T value);
        T GetOptions<T>(object instance);
    }
}
