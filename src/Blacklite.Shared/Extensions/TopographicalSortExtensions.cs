using System;
using System.Collections.Generic;

namespace Blacklite.TopographicalSort
{
    public static class TopographicalSortExtensions
    {
        public static IEnumerable<T> TopographicalSort<T>([NotNull] this IEnumerable<T> source, [NotNull] Func<T, IEnumerable<T>> dependencies)
        {
            var sorted = new List<T>();
            var visited = new HashSet<T>();

            foreach (var item in source)
                Visit(item, visited, sorted, dependencies);

            return sorted;
        }

        private static void Visit<T>(T item, HashSet<T> visited, List<T> sorted, Func<T, IEnumerable<T>> dependencies)
        {
            if (!visited.Contains(item))
            {
                visited.Add(item);

                foreach (var dep in dependencies(item))
                    Visit(dep, visited, sorted, dependencies);

                sorted.Add(item);
            }
            else
            {
                if (!sorted.Contains(item))
                    throw new NotSupportedException(string.Format("Cyclic dependency found {0}", item));
            }
        }
    }
}
