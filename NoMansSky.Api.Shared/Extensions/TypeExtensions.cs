using NoMansSky.Api.Definitions;
using System;
using System.Linq;
using System.Reflection;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="Type"/>.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Returns whether or not this type is a vector.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static bool IsVectorType(this Type instance)
        {
            return instance.Name.ToLower().Contains("vector");
        }

        public static bool ShouldInstantiateWithPtr(this Type instance)
        {
            return instance.ShouldInstantiateWithPtr(out var ctor);
        }

        public static bool ShouldInstantiateWithPtr(this Type instance, out ConstructorInfo ctor)
        {
            var typeToCheck = instance.IsAssignableTo(typeof(IPtr)) ? instance.GenericTypeArguments.First() : instance;

            ctor = typeToCheck.GetConstructors().FirstOrDefault(c =>
            {
                var paramaters = c.GetParameters();
                bool isParamPointer = paramaters.Any(p => p.ParameterType == typeof(long) && p.Name == "pointer");
                return paramaters.Length == 1 && isParamPointer;
            });

            return ctor != null;
        }
    }
}
