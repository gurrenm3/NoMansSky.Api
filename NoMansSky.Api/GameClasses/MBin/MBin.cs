using libMBIN;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an MBIN file.
    /// </summary>
    public class MBin : IMBin, IEquatable<IMBin>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsInitialized { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string MBinName { get; private set; } = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string FullName { get; private set; } = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long Address { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Type MBinType { get; private set; } = null!;

        public MBin()
        {

        }

        public MBin(string name, long address)
        {
            Init(name, address);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="initializeOnce"></param>
        public virtual bool Init(string name, long address, bool initializeOnce = true)
        {
            if (initializeOnce && IsInitialized)
                return false;

            Address = address;
            MBinType = IGame.Instance.MBinManager.GetMBinType(name);

            string cleanedName = name.Replace(" ", "");
            if (cleanedName.Contains("/"))
            {
                var split = cleanedName.Split('/');
                cleanedName = split[split.Length - 1]; // set to last
            }
            else if (cleanedName.Contains("\\"))
            {
                var split = cleanedName.Split('/');
                cleanedName = split[split.Length - 1]; // set to last
            }

            cleanedName = cleanedName.TrimEnd('/').TrimEnd('\\');

            if (cleanedName.ToLower().EndsWith(".mbin") || cleanedName.ToLower().EndsWith(".mxml"))
                cleanedName = cleanedName.Remove(cleanedName.Length - 5, 5);

            MBinName = cleanedName;
            FullName = name;
            IsInitialized = true;
            return true;
        }

        /// <summary>
        /// Returns a formatted version of this mbin.
        /// <br/>MBin Fullname: GcPlayerGlobals | Address: 123456789
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Address: {Address.ToHex()} Fullname: {FullName}";
        }

        /// <summary>
        /// Returns whether or not this MBin is equal to the provided object.
        /// <br/>If provided object is an IMbin file, function will returns whether 
        /// or not this MBin and the provided one are referring to the same mbin in memory.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is IMBin mBin)
                return Equals(mBin);

            return base.Equals(obj);
        }

        /// <summary>
        /// Returns whether or not this MBin and the provided one are referring to the same mbin in memory.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(IMBin? other)
        {
            if (other == null)
                return false;

            return this.Address == other.Address && this.FullName == other.FullName;
        }
    }
}
