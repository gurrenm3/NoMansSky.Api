using libMBIN;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Reflection;
using System.Xml.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// A manager for dealing with MBIN files.
    /// </summary>
    internal class MBinManager : IMBinManager
    {
        private static readonly Assembly libmbinAssembly = typeof(NMSTemplate).Assembly;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<IMBin> OnMBinLoaded { get; set; } = new SharedModEvent<IMBin>();
        private List<IMBin> loadedMbinFiles = new List<IMBin>();

        private PakManager pakManager = new PakManager();

        public MBinManager()
        {
            
        }

        internal void LoadPakFiles(string directory)
        {
            pakManager.LoadFromDirectory(directory);
        }

        /// <summary>
        /// Returns a new list containing all of the loaded MBIN files.
        /// <br/>A new list is returned in order to prevent accidentally modifying the origninal list.
        /// </summary>
        /// <returns></returns>
        public List<IMBin> GetAllMBin()
        {
            return new List<IMBin>(loadedMbinFiles);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IMBin GetMBin<T>()
        {
            return GetMBin(typeof(T).Name);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="mbinName"></param>
        /// <returns></returns>
        public IMBin GetMBin(string mbinName, bool useFullName = false)
        {
            if (loadedMbinFiles.Count == 0)
            {
                ConsoleUtils.LogError("Failed to get mbin because none have been loaded yet." +
                    " Consider running your code later in the game's execution.");
                return null!;
            }

            mbinName = mbinName.ToUpper().Replace("/", "\\");

            // Doing 2 loops below to check for the exact mbin name or almost exact mbin name.
            // Ex: the programmer typed AiSpachshipGlobals instead of GcAiSpaceshipGlobals. We
            // can add the Gc to the front since it's obvious what they meant. There are 2 loops
            // because it's possible in the future there will be an AiSpachshipGlobals without the Gc
            // so we're checking if it's been typed correctly first.

            // check if the exact name is correct.
            foreach (var mbin in loadedMbinFiles)
            {
                string compareName = useFullName ? mbin.FullName : mbin.Name;
                if (mbinName == compareName.ToUpper().Replace("/", "\\"))
                    return mbin;
            }

            // try messing with the characters to see if the name entered was almost right.
            foreach (var mbin in loadedMbinFiles)
            {
                string compareName = useFullName ? mbin.FullName : mbin.Name;
                var currentMbinName = compareName.ToUpper().Replace("/", "\\");
                if (mbinName == currentMbinName.Insert(0, "GC") || mbinName.Insert(0, "GC") == currentMbinName || mbinName == currentMbinName.Insert(0, "CGC") || mbinName.Insert(0, "CGC") == currentMbinName)
                    return mbin;
            }

            return null!;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="mbinName"></param>
        /// <returns></returns>
        public Type GetMBinTypeFromName(string mbinName)
        {
            mbinName = mbinName.ToUpper();
            if (string.IsNullOrEmpty(mbinName))
            {
                ConsoleUtils.LogError("Can't get mbin type because provided mbin name was invalid");
                return null!;
            }                

            // clean the name a bit

            if (mbinName.StartsWith("GLOBALS\\"))
                mbinName = mbinName.Replace("GLOBALS\\", "");

            if (mbinName.StartsWith("CGC") || mbinName.StartsWith("CTK"))
                mbinName = mbinName.Remove(0, 1);

            // try to get the type

            Type mbinType = null;

            if (mbinName.Contains("\\"))
            {
                mbinType = pakManager.GetMbinType(mbinName);
            }
            else  // it's probably a game component name and not a path
            {
                if (!mbinName.StartsWith("TK") && !mbinName.StartsWith("GC"))
                    mbinName = mbinName.Insert(0, "GC"); // assume it's a game component.

                mbinType = libmbinAssembly.GetTypes().FirstOrDefault(type => type.Name.ToUpper() == mbinName);
            }


            /*if (mbinType == null)
                Mod.Instance.Logger.WriteLine($"{mbinName} - Couldn't get mbin Type, might be an internal class.", LogLevel.Warning);*/

            return mbinType;
        }


        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="mbinToRegister"></param>
        public bool RegisterMBin(IMBin mbinToRegister)
        {
            string mbinFullName = mbinToRegister.FullName.ToUpper();
            if (loadedMbinFiles.Any(mbin => mbin.FullName.ToUpper() == mbinFullName))
            //if (loadedMBIN.Any(mbin => mbin.Equals(mbinToRegister)))
                return false;
            
            loadedMbinFiles.Add(mbinToRegister);
            //mbinToRegister.Init(mbinToRegister.FullName, mbinToRegister.Address);
            OnMBinLoaded.Invoke(mbinToRegister);
            return true;
        }
    }
}
