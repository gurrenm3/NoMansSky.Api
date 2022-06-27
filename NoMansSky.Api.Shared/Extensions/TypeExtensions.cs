using System;

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
    }
}
