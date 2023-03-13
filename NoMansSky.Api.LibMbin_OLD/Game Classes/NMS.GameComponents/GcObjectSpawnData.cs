using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcObjectSpawnData : NMSTemplate
{
	public NMSString0x10 DebugName
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectSpawnData.TypeEnum Type
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectSpawnData.TypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectSpawnData.TypeEnum>(value);
	}

	public GcResourceElement Resource
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public VirtualList<GcResourceElement> AltResources
	{
		get => cache.GetOrAddValue(new VirtualList<GcResourceElement>(address + GetOffset()));
		set => TrySetValue<GcResourceElement>(value);
	}

	public VirtualList<GcTerrainTileType> ExtraTileTypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcTerrainTileType>(address + GetOffset()));
		set => TrySetValue<GcTerrainTileType>(value);
	}

	public NMSString0x10 Placement
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectSpawnData.PlacementPriorityEnum PlacementPriority
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectSpawnData.PlacementPriorityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectSpawnData.PlacementPriorityEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectSpawnData.LargeObjectCoverageEnum LargeObjectCoverage
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectSpawnData.LargeObjectCoverageEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectSpawnData.LargeObjectCoverageEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectSpawnData.OverlapStyleEnum OverlapStyle
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectSpawnData.OverlapStyleEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectSpawnData.OverlapStyleEnum>(value);
	}

	public Single MinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RelativeToSeaLevel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean MatchGroundColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectSpawnData.GroundColourIndexEnum GroundColourIndex
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectSpawnData.GroundColourIndexEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectSpawnData.GroundColourIndexEnum>(value);
	}

	public Boolean SwapPrimaryForSecondaryColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SwapPrimaryForRandomColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlignToNormal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinScaleY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxScaleY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlopeScaling
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PatchEdgeScaling
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxXZRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AutoCollision
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CollideWithPlayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CollideWithPlayerVehicle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DestroyedByPlayerVehicle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DestroyedByPlayerShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DestroyedByTerrainEdit
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InvisibleToCamera
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CreaturesCanEat
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ShearWindStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 DestroyedByVehicleEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcObjectSpawnDataVariant QualityVariantData
	{
		get => GetValue<GcObjectSpawnDataVariant>();
		set => TrySetValue<GcObjectSpawnDataVariant>(value);
	}

	public VirtualList<GcObjectSpawnDataVariant> QualityVariants
	{
		get => cache.GetOrAddValue(new VirtualList<GcObjectSpawnDataVariant>(address + GetOffset()));
		set => TrySetValue<GcObjectSpawnDataVariant>(value);
	}

	public GcObjectSpawnData(long address) : base(address)
	{

	}
}
