using System;
// ReSharper disable CheckNamespace

namespace System.Reflection
{
    public static class TypeInfoExtensions
    {
        public static PropertyInfo FindDeclaredProperty(this TypeInfo typeInfo, string name)
        {
            while (typeInfo != null)
            {
                var property = typeInfo.GetDeclaredProperty(name);
                if (property != null)
                    return property;

                typeInfo = typeInfo?.BaseType?.GetTypeInfo();
            }

            return null;
        }
    }
}