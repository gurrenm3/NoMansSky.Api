using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class SpaceColorSetting : ISpaceColorSetting
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnLoaded { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IMBin MBin { get; set; }

        public SpaceColorSetting()
        {

        }
    }
}
