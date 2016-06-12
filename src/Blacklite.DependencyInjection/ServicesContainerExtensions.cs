using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Blacklite;
using Scrutor;

// ReSharper disable CheckNamespace

// We're cheating here, so we don't have to have two different difference namespaces everywhere
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServicesContainerExtensions
    {
        public static IServiceCollection AddAssembly([NotNull] this IServiceCollection collection, [NotNull] object context)
        {
            return collection.AddAssembly(context.GetType());
        }

        public static IServiceCollection AddAssembly([NotNull] this IServiceCollection collection, [NotNull] Type type)
        {
            var assembly = type.GetTypeInfo().Assembly;

            return collection.AddAssembly(assembly);
        }

        public static IServiceCollection AddAssembly([NotNull] this IServiceCollection collection, [NotNull] Assembly assembly)
        {
            return collection.Scan((a) =>
            {
                a.FromAssemblies(assembly)
                    .AddClasses()
                    .UsingAttributes();
            });
        }
    }
}
