using System;
using System.Collections.Generic;
using System.Reflection;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Describers
{
    public interface IFeatureTypeProvider
    {
        IEnumerable<TypeInfo> FeatureTypes { get; }
    }
}
