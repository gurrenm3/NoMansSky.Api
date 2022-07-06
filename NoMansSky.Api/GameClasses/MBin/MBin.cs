using libMBIN;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an MBIN file.
    /// </summary>
    public class MBin : IMBin
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string Name { get; init; } = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long Address { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Type MBinType { get; init; } = null!;

        public MBin(string name, long address)
        {
            Name = name;
            Address = address;
            
            MBinType = GetMBinType(name);
            /*if (MBinType == null)
            {
                ConsoleUtil.LogError($"Failed to get mbin type for {name}");
            }*/
        }

        /// <summary>
        /// Returns the libmbin class type with the provided name.
        /// </summary>
        /// <param name="mbinName"></param>
        /// <returns></returns>
        private Type GetMBinType(string mbinName)
        {
            mbinName = mbinName.ToLower();
            var types = typeof(NMSTemplate).Assembly.GetTypes();

            // not checking twice like in GetMbin because it's too many types to loop over twice.

            foreach (var type in types)
            {
                var currentMbinName = type.Name.ToLower();
                if (mbinName == type.Name.ToLower() || mbinName == currentMbinName.Insert(0, "gc") || mbinName.Insert(0, "gc") == currentMbinName || mbinName == currentMbinName.Insert(0, "cgc") || mbinName.Insert(0, "cgc") == currentMbinName)
                    return type;
            }

            return null!;
        }

        public override string ToString()
        {
            return $"MBinName: {Name} | Address: {Address.ToHex()}";
        }
    }
}
