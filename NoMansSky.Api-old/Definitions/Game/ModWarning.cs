using Reloaded.Memory.Sources;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the "Warning, Mods are Enabled" popup that shows at the beginning of the game.
    /// <br/><br/>Thanks to RaYRoD TV#7679 for discovering and sharing this.
    /// </summary>
    internal unsafe class ModWarning : IModWarning
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsEnabled => *(bool*)address;

        private const string pattern = "C6 80 92 26 00 00 ??";
        private MemoryAddress<bool> memoryAddress;
        private IModLogger _logger;
        private long address;

        public ModWarning(IModLogger logger)
        {
            _logger = logger;            
            Init();
        }

        private void Init()
        {
            address = new Signature(pattern).Scan() + 0x6;
            
            memoryAddress = new MemoryAddress<bool>(address);
            Memory.Instance.ChangePermission((nuint)address, 1, Reloaded.Memory.Kernel32.Kernel32.MEM_PROTECTION.PAGE_EXECUTE_READWRITE);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public void Enable()
        {
            if (IsEnabled)
            {
                _logger.WriteLine($"Tried enabling the \"Mod Warning Popup\" but is already enabled.", LogLevel.Warning);
                return;
            }

            *(bool*)address = true;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public void Disable()
        {
            if (!IsEnabled)
            {
                _logger.WriteLine($"Tried disabling the \"Mod Warning Popup\" but is already disabled.", LogLevel.Warning);
                return;
            }

            *(bool*)address = false;
        }
    }
}

