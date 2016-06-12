using System;
using System.Collections.Generic;

// ReSharper disable CheckNamespace

namespace Blacklite.Features.Describers
{
    public interface IFeatureDescriberProvider
    {
        IReadOnlyDictionary<Type, IFeatureDescriber> Describers { get; }
    }
}
