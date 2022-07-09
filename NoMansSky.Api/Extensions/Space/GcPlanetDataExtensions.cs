using libMBIN.NMS.GameComponents;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for GcPlanetData.
    /// </summary>
    public static class GcPlanetDataExtensions
    {
        /// <summary>
        /// Returns all of the External Environment Objects (objects used outside) on this planet.
        /// </summary>
        /// <param name="planetData"></param>
        /// <returns></returns>
        public static List<IEnvironmentObject> GetEnvironmentObjects(this GcPlanetData planetData)
        {
            List<string> externalObjMbins = new List<string>();
            foreach (var externalObjectLists in planetData.GenerationData.ExternalObjectLists)
            {
                foreach (var mbinName in externalObjectLists.Options)
                {
                    externalObjMbins.Add(mbinName.Value);
                }
            }

            var allEnvironmentObjects = IGame.Instance?.EnvironmentObjects;
            if (allEnvironmentObjects == null)
                return null!;

            List<IEnvironmentObject> environmentObjects = new List<IEnvironmentObject>();
            foreach (var mbin in externalObjMbins)
            {
                var obj = allEnvironmentObjects.FirstOrDefault(o => o.MBinName == mbin);
                if (obj != null)
                {
                    environmentObjects.Add(obj);
                }
            }

            return allEnvironmentObjects;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="planetData"></param>
        /// <param name="newValue"></param>
        private static void SetEnvironmentObjects(this GcPlanetData planetData, List<IEnvironmentObject> newValue)
        {
            // this will require modding GcPlanetData.GenerationData.ExternalObjectLists
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="planetData"></param>
        /// <param name="modifyAction"></param>
        private static void ModifyEnvironmentObjects(this GcPlanetData planetData, Action<List<IEnvironmentObject>> modifyAction)
        {
            // this extension is TODO because SetEnvironmentObjects isn't done yet.

            var spawnData = planetData.GetEnvironmentObjects();
            modifyAction?.Invoke(spawnData);
            planetData.SetEnvironmentObjects(spawnData);
        }
    }
}
