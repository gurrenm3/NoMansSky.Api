using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTerrainEditing : NMSTemplate
{
	public Single EditPlaneMaxAdditiveOffsetFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EditPlaneMinAdditiveOffsetFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EditPlaneMaxSubtractiveOffsetFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EditPlaneMinSubtractiveOffsetFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainEditBeamMaxRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainEditBeamSpherecastRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainEditBeamAddInterpolationStepFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainEditBeamSubtractInterpolationStepFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainBlocksSearchRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RegionMapSearchRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinimumSubstancePresence
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RegionEditAreaMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DensityBlendDistanceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainEditBaseDistanceTolerance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainUndoBaseDistanceTolerance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UndoEditToleranceFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UndoBaseEditEffectiveScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainEditsNormalCostFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainEditsSurvivalCostFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VoxelsDeletedAffectCostFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EditGunBeamEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EditGunParticlesEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SubtractGunBeamEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SubtractGunParticlesEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<Single> EditSizes
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 8));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> SubtractSizes
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> BaseEditSizes
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 2));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> UndoEditSizes
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 2));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> FlatteningSizes
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 1));
		set => TrySetValue<Single>(value);
	}

	public Single EditEffectScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTerrainEditing(long address) : base(address)
	{

	}
}
