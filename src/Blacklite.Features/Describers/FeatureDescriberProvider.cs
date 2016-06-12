using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
#if DNX451 || DNXCORE50
using Microsoft.Extensions.Runtime;
#endif

namespace Blacklite.Features.Describers
{
    class FeatureDescriberProvider : IFeatureDescriberProvider
    {
        public FeatureDescriberProvider(IFeatureTypeProvider featureTypeProvider, IFeatureDescriberFactory factory)
        {
            var dictionary = factory.Create(featureTypeProvider.FeatureTypes)
                .ToDictionary(x => x.Type);

            Describers = new ReadOnlyDictionary<Type, IFeatureDescriber>(dictionary);
        }

        public IReadOnlyDictionary<Type, IFeatureDescriber> Describers { get; }
    }
}
