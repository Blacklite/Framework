using System;
using System.Collections.Generic;
using System.Reflection;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Describers
{
    public interface IFeatureAssemblyProvider
    {
        IEnumerable<Assembly> Assemblies { get; }
    }
}
