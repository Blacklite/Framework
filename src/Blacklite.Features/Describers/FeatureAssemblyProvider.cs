using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyModel;

namespace Blacklite.Features.Describers
{
    public class FeatureAssemblyProvider : IFeatureAssemblyProvider
    {
        public FeatureAssemblyProvider(IFeatureDescriberFactory factory)
        {
            var assemblies = GetAssemblies();
            Assemblies = assemblies.ToArray();
        }

        public IEnumerable<Assembly> Assemblies { get; }

        protected virtual HashSet<string> ReferenceAssemblies { get; } = new HashSet<string>(StringComparer.Ordinal) {
            "Blacklite.Features",
            "Blacklite.Multitenancy.Features",
        };

        private IEnumerable<Assembly> GetAssemblies()
        {
            return ReferenceAssemblies
                .SelectMany(
                    x => DependencyContext.Default.RuntimeLibraries.Where(z => z.Dependencies.Any(c => c.Name == x)))
                .Distinct()
                .SelectMany(x => x.GetDefaultAssemblyNames(DependencyContext.Default))
                .Select(Load);
        }

        private static Assembly Load(AssemblyName assemblyName)
        {
            return Assembly.Load(assemblyName);
        }
    }


}
