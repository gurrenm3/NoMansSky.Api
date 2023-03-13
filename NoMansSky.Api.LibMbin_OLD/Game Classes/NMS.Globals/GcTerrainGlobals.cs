using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTerrainGlobals : NMSTemplate
{
	public Single RegisterTerrainMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainBeamUndoRangeFromLastAdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainBeamHologramTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseWheelRotatePlaneSensitivity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubtractEditOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubtractEditLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubtractEditFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainBeamDefaultRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainBeamLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour TerrainBeamLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single UseMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextureFadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextureFadePower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextureScaleMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextureScalePower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmoothStepBelow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmoothStepAbove
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmoothStepStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TileBlendMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DebugFlattenAllTerrain
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugNoFlattenForBuildings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugLockTerrainSettingsIndex
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 NumGeneratorCalls
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumPolygoniseCalls
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumPostPolygoniseCalls
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MinHighWaterLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHighWaterLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinHighWaterRegionRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinHighWaterRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHighWaterRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinWaterRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxWaterRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x10> MiningSubstanceBiome
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> MiningSubstanceStar
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> MiningSubstanceStarExtreme
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> MiningSubstanceRare
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single TextureBlendScale0
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextureBlendScale1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextureBlendScale2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextureBlendOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTerrainOverlayColours HueOverlay
	{
		get => GetValue<GcTerrainOverlayColours>();
		set => TrySetValue<GcTerrainOverlayColours>(value);
	}

	public GcTerrainOverlayColours SaturationOverlay
	{
		get => GetValue<GcTerrainOverlayColours>();
		set => TrySetValue<GcTerrainOverlayColours>(value);
	}

	public GcTerrainOverlayColours ValueOverlay
	{
		get => GetValue<GcTerrainOverlayColours>();
		set => TrySetValue<GcTerrainOverlayColours>(value);
	}

	public GcTerrainEditing TerrainEditing
	{
		get => GetValue<GcTerrainEditing>();
		set => TrySetValue<GcTerrainEditing>(value);
	}

	public Single TerrainUndoCubesRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainUndoCubesAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainUndoCubesNoiseThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainUndoCubesNoiseFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainUndoFadeDepthConstant
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainUndoFadeDepthScalar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DebugRegionHotspots
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 RegionHotspotsTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 TerrainPrimeIndexStart
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcTerrainGlobals(long address) : base(address)
	{

	}
}
