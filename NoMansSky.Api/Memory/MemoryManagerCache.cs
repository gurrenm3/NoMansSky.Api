using libMBIN;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    internal class MemoryManagerCache
    {
        private Dictionary<string, MemoryInfo> addressCache = new Dictionary<string, MemoryInfo>();
        private static IMBinManager MBinManager => IGame.Instance?.MBinManager;

        public MemoryManagerCache()
        {

        }

        public MemoryInfo GetAddressInfo(string path)
        {
            //objectType = null;
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Tried getting the address of an empty path.");

            if (addressCache.TryGetValue(path, out var memInfo))
                return memInfo;

            if (MBinManager == null)
                throw new NullReferenceException("Error! MBinManager is null! This is not suppose to happen!");

            // create path array.
            string[] pathSplit = path.Contains(".") ? path.Split('.') : pathSplit = new string[1] { path };
            string mbinName = pathSplit[0];
            var mbin = MBinManager.GetMbin(mbinName);
            if (mbin == null)
                throw new Exception($"Failed to get mbin with the name of \"{mbinName}\"");

            var currentType = MBinManager?.GetMbinType(mbinName);
            if (currentType == null)
                throw new Exception($"Failed to get the type for the mbin with the name of \"{mbinName}\"");

            // code below is getting offsets from each variable. Haven't checked arrays/lists yet.
            long currentAddress = mbin.Address;
            for (int i = 1; i < pathSplit.Length; i++)
            {
                string className = currentType.Name;
                string fieldName = pathSplit[i];

                int offset = NMSTemplate.OffsetOf(className, fieldName);
                currentAddress += offset;
                currentType = currentType?.GetField(fieldName).FieldType;
            }

            memInfo = new MemoryInfo() { objectType = currentType, address = currentAddress };
            addressCache.Add(path, memInfo);
            return memInfo;
        }
    }
}
