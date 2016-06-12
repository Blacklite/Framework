using System;
// ReSharper disable CheckNamespace

namespace Blacklite
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class NotNullAttribute : Attribute
    {
    }
}
