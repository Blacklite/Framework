using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite
{
    // just used to he a hold of the has flag method info.
    enum HasFlagEnum { }

    public static class EnumExtensions
    {
        private static MethodInfo _hasFlagMethod = typeof(Enum).GetTypeInfo().DeclaredMethods.Single(x => x.Name == nameof(HasFlagEnum.HasFlag));

        public static IEnumerable<T> GetFlags<T>(this Enum value)
            where T : struct
        {
            return value.GetFlags().Cast<T>();
        }

        public static IEnumerable<Enum> GetFlags(this Enum value)
        {
            return Enum.GetValues(value.GetType())
                         .Cast<Enum>()
                         .Where(m => (bool)_hasFlagMethod.Invoke(value, new[] { m }));
        }
    }
}
