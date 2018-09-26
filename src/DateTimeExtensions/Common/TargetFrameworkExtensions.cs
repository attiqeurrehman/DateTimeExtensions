using System;
using System.Collections.Generic;
using System.Reflection;

namespace DateTimeExtensions.Common
{
    internal static class TargetFrameworkExtensions
    {
#if NET35
        public static Type GetTypeInfo(this Type type)
        {
            return type;
        }

        
#endif

        public static IEnumerable<ConstructorInfo> GetDeclaredConstructors(this Type type)
        {
#if NET35
            return type.GetConstructors();
#else
            return type.GetTypeInfo().DeclaredConstructors;
#endif
        }

        internal static IEnumerable<Type> GetAssemblyTypes(this Assembly assembly)
        {
#if NET35
            return assembly.GetTypes();
#else
            return assembly.ExportedTypes;
#endif
        }
    }
}
