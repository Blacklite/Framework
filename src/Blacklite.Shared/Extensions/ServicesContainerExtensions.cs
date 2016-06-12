using Blacklite;
using Blacklite;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// We're cheating here, so we don't have to have two different difference namespaces everywhere
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServicesContainerExtensions
    {
        public static bool TryAddImplementation([NotNull] this IServiceCollection collection, [NotNull] ServiceDescriptor descriptor)
        {
            if (descriptor.ImplementationType != null && !collection.Any(d => d.ServiceType == descriptor.ServiceType && d.ImplementationType == descriptor.ImplementationType))
            {
                collection.Add(descriptor);
                return true;
            }

            if (descriptor.ImplementationInstance != null && !collection.Any(d => d.ServiceType == descriptor.ServiceType && d.ImplementationInstance == descriptor.ImplementationInstance))
            {
                collection.Add(descriptor);
                return true;
            }

            collection.TryAdd(descriptor);
            return true;
        }

        public static bool TryAddImplementation([NotNull] this IServiceCollection collection, [NotNull] IEnumerable<ServiceDescriptor> descriptors)
        {
            bool anyAdded = false;
            foreach (var d in descriptors)
            {
                anyAdded = collection.TryAddImplementation(d) || anyAdded;
            }
            return anyAdded;
        }
    }
}
