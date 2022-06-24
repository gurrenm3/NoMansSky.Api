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
        [FieldOffset(0x0)]
        public long username;

        /// <summary>
        /// TODO: This is probably the list of player stats.
        /// </summary>
        [FieldOffset(0x180)]
        public long RealityIndex;

        /// <summary>
        /// The player's current shield value.
        /// </summary>
        [FieldOffset(0x1B0)]
        public int shield;

        /// <summary>
        /// The player's current health.
        /// </summary>
        [FieldOffset(0x1B4)]
        public int health;

        /// <summary>
        /// The player's current units (cash).
        /// </summary>
        [FieldOffset(0x1BC)]
        public int units;

        /// <summary>
        /// The player's current nanites.
        /// </summary>
        [FieldOffset(0x1C0)]
        public int nanites;

        /// <summary>
        /// The player's current quicksilver (specials).
        /// </summary>
        [FieldOffset(0x1C4)]
        public int quicksilver;        

        /// <summary>
        /// The health of the player's active ship.
        /// </summary>
        [FieldOffset(0x1B8)]
        public int shipHealth;


        // each of the exosuit inventories is 258 away from the previous one.

        /// <summary>
        /// Offset to the start of the Exosuit's general inventory.
        /// </summary>
        [FieldOffset(0x310)] // was 0x1D0
        public long exosuitInventoryAddress;

        /// <summary>
        /// Offset to the start of the Exosuit's technology inventory.
        /// </summary>
        [FieldOffset(0x568)] // was 0x3E8
        public long exosuitTechnologyAddress;

        /// <summary>
        /// Offset to the start of the Exosuit's cargo inventory.
        /// </summary>
        [FieldOffset(0x7C0)] // was 600
        public long exosuitCargoAddress;

        /// <summary>
        /// Offset to the start of the MultiTool Inventory.
        /// </summary>
        [FieldOffset(0xA18)]
        public long weaponInventory;

        /// <summary>
        /// Offset to the start of the Exosuit's cargo inventory.
        /// </summary>
        [FieldOffset(0x1378)]
        public long freighterInventory;
    }
}