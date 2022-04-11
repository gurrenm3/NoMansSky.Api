using System.Runtime.InteropServices;

namespace NoMansSky.Api
{
    /// <summary>
    /// Contains important info about the player, like their Units, inventory, and Health.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct GcPlayerStateData
    {
        /// <summary>
        /// TODO: This is probably the list of player stats.
        /// </summary>
        [FieldOffset(0x20)]
        public long stats;

        /// <summary>
        /// The player's current shield value.
        /// </summary>
        [FieldOffset(0xB0)]
        public int shield;

        /// <summary>
        /// The player's current health.
        /// </summary>
        [FieldOffset(0xB4)]
        public int health;

        /// <summary>
        /// The player's current units (cash).
        /// </summary>
        [FieldOffset(0xBC)]
        public int units;

        /// <summary>
        /// The player's current nanites.
        /// </summary>
        [FieldOffset(0xC0)]
        public int nanites;

        /// <summary>
        /// The player's current quicksilver (specials).
        /// </summary>
        [FieldOffset(0xC4)]
        public int quicksilver;        

        /// <summary>
        /// The health of the player's active ship.
        /// </summary>
        [FieldOffset(0xB8)]
        public int shipHealth;

        /// <summary>
        /// Offset to the start of the Exosuit's general inventory.
        /// </summary>
        [FieldOffset(0x1D0)]
        public long exosuitInventoryAddress;

        /// <summary>
        /// Offset to the start of the Exosuit's technology inventory.
        /// </summary>
        [FieldOffset(0x3E8)]
        public long exosuitTechnologyAddress;

        /// <summary>
        /// Offset to the start of the Exosuit's cargo inventory.
        /// </summary>
        [FieldOffset(0x600)]
        public long exosuitCargoAddress;
    }
}