using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Links a Biome MBin File with it's address in memory.
    /// </summary>
    internal class EnvironmentObject : IEnvironmentObject, IEquatable<IEnvironmentObject>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string MBinName { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long Address { get; set; }

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public EnvironmentObject()
        {

        }

        /// <summary>
        /// Creates an instance of this class while providing it's mbin and address.
        /// </summary>
        /// <param name="mbinName"></param>
        /// <param name="address"></param>
        public EnvironmentObject(string mbinName, long address)
        {
            MBinName = mbinName;
            Address = address;
        }

        /// <summary>
        /// Returns whether or not the provided <see cref="IEnvironmentObject"/> has
        /// the same values as this one. If true it means these are referencing the same file 
        /// and address in memory.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(IEnvironmentObject? other)
        {
            if (other == null)
                return false;

            return other.MBinName == MBinName && other.Address == Address;
        }

        public override bool Equals(object? obj)
        {
            if (obj is IEnvironmentObject environmentObject)
                return Equals(environmentObject);

            return base.Equals(obj);
        }
    }
}
