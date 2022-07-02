using libMBIN;
using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// A manager for dealing with MBIN files.
    /// </summary>
    public class MBinManager : IMBinManager
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<IMBin> OnMBinLoaded { get; set; } = new SharedModEvent<IMBin>();
        private List<IMBin> loadedMBIN = new List<IMBin>();

        public MBinManager()
        {
            OnMBinLoaded += (mbin) =>
            {
                // ignore duplicates 
                if (!loadedMBIN.Any(m=>m.Address == mbin.Address))
                    loadedMBIN.Add(mbin);
            };
        }

        /// <summary>
        /// Returns a new list containing all of the loaded MBIN files.
        /// <br/>A new list is returned in order to prevent accidentally modifying the origninal list.
        /// </summary>
        /// <returns></returns>
        public List<IMBin> GetAllMBIN()
        {
            List<IMBin> mbin = new List<IMBin>();
            mbin.AddRange(loadedMBIN);
            return mbin;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="mbinName"></param>
        /// <returns></returns>
        public IMBin GetMbin(string mbinName)
        {
            if (loadedMBIN.Count == 0)
            {
                ConsoleUtil.LogError("Failed to get mbin because none have been loaded yet." +
                    " Consider running your code later in the game's execution.");
                return null!;
            }

            mbinName = mbinName.ToLower();

            // Doing 2 loops below to check for the exact mbin name or almost exact mbin name.
            // Ex: the programmer typed AiSpachshipGlobals instead of GcAiSpaceshipGlobals. We
            // can add the Gc to the front since it's obvious what they meant. There are 2 loops
            // because it's possible in the future there will be an AiSpachshipGlobals without the Gc
            // so we're checking if it's been typed correctly first.

            // check if the exact name is correct.
            foreach (var mbin in loadedMBIN)
            {
                if (mbinName == mbin.Name.ToLower())
                    return mbin;
            }

            // try messing with the characters to see if the name entered was almost right.
            foreach (var mbin in loadedMBIN)
            {
                var currentMbinName = mbin.Name.ToLower();
                if (mbinName == currentMbinName.Insert(0, "gc") || mbinName.Insert(0, "gc") == currentMbinName || mbinName == currentMbinName.Insert(0, "cgc") || mbinName.Insert(0, "cgc") == currentMbinName)
                    return mbin;
            }

            return null!;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="mbinName"></param>
        /// <returns></returns>
        public Type GetMbinType(string mbinName)
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
    }
}
