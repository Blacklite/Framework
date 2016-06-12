using Blacklite.Shared.Reflection.Extensions.InjectorExtension;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Shared.Reflection
{
    public static class InjectorExtensions
    {
        public static InjectableMethodBuilder CreateInjectableMethod([NotNull]  this TypeInfo typeInfo, [NotNull] string methodName, Func<MethodInfo, bool> predicate = null)
        {
            // Warn that there is no execute method.
            var methodInfos = typeInfo.DeclaredMethods
                .Where(x => x.Name == methodName);

            if (predicate != null)
                methodInfos = methodInfos.Where(predicate);

            var methodInfo = methodInfos.FirstOrDefault();

            return methodInfo?.CreateInjectableMethod();
        }

        public static InjectableMethodBuilder CreateInjectableMethod([NotNull]this MethodInfo methodInfo)
        {
            return new InjectableMethodBuilder(methodInfo);
        }
    }
}
