using System;
using System.Reflection;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Describers
{
    public interface IFeaturePropertyDescriber
    {
        Type Type { get; }
        TypeInfo TypeInfo { get; }
        string Name { get; }
        string DisplayName { get; }
        string Description { get; }
        bool IsReadOnly { get; }
        T GetProperty<T>(object instance);
        void SetProperty(object instance, object value);
    }
}
