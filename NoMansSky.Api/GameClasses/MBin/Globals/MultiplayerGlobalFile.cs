﻿using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Multiplayer global mbin file.
    /// <br/>The exact mbin type is GcMultiplayerGlobals.
    /// </summary>
    internal class MultiplayerGlobalFile : IMultiplayerGlobalFile
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnLoaded { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IMBin MBin { get; set; }
    }
}
