using System;
using System.Collections.Generic;
using Blacklite.Features.OptionsModel;
// ReSharper disable CheckNamespace

namespace Blacklite.Features
{
    // ReSharper disable once InconsistentNaming
    public interface Feature<out TFeature>
        where TFeature : class
    {
        TFeature Value { get; }
    }
}
