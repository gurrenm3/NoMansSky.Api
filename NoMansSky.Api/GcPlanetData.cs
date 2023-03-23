using System.Runtime.InteropServices;

namespace NoMansSky.Api.libMBIN;

[StructLayout(LayoutKind.Explicit, Size = 0x3EA0)]
public unsafe partial struct GcPlanetData
{

    [FieldOffset(0x0)] public NMSString0x80 name;

    [FieldOffset(0x80)] public GcPlanetLife life;

    [FieldOffset(0x84)] public GcPlanetLife creatureLife;

    [FieldOffset(0x88)] public long hazard;

    [FieldOffset(0xD8)] public int resourceLevel;

    [FieldOffset(0xDC)] public long buildingLevel;

    [FieldOffset(0xE0)] public NMSString0x80 commonSubstanceID;

    [FieldOffset(0xF0)] public NMSString0x80 uncommonSubstanceID;

    [FieldOffset(0x100)] public NMSString0x80 rareSubstanceID;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x10)]  // TkDynamicArray<GcPlanetDataResourceHint>

    [FieldOffset(0x110)] public byte[] extraResourceHints;

    [FieldOffset(0x120)] public long colours;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x17)]

    [FieldOffset(0x1A80)] public long[] tileColours;

    [FieldOffset(0x1BF0)] public long weather;

    [FieldOffset(0x1D50)] public long clouds;

    [FieldOffset(0x1D90)] public long water;

    [FieldOffset(0x1F10)] public NMSString0x80 terrainFile;

    [FieldOffset(0x1F90)] public long terrain;

    [FieldOffset(0x3560)] public int tileTypeSet;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x10)]  // TkDynamicArray<int>

    [FieldOffset(0x3568)] public byte[] tileTypeIndices;

    [FieldOffset(0x3578)] public long spawnData;

    [FieldOffset(0x35D8)] public long inhabitingRace;

    [FieldOffset(0x35E0)] public long buildingData;

    [FieldOffset(0x3628)] public long generationData;

    [FieldOffset(0x3A90)] public long sentinelTimer;

    [FieldOffset(0x3A98)] public long flybyTimer;

    [FieldOffset(0x3AA0)] public GcPlanetInfo planetInfo;

    [FieldOffset(0x3E24)] public long sentinelData;

    [FieldOffset(0x3E30)] public long rings;

    [FieldOffset(0x3E90)] public bool inEmptySystem;

    [FieldOffset(0x3E91)] public bool inAbandonedSystem;

    [FieldOffset(0x3E94)] public float fuelMultiplier;
}
