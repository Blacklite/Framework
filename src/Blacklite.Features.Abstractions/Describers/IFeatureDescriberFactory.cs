using System.Collections.Generic;
using System.Reflection;
// ReSharper disable CheckNamespace

namespace Blacklite.Features.Describers
{
    public interface IFeatureDescriberFactory
    {
        IEnumerable<IFeatureDescriber> Create(IEnumerable<TypeInfo> descriptors);
    }
}
