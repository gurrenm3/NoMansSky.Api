using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingSpawnData : NMSTemplate
{
	public Single Density
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcResourceElement Resource
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public Int32 LSystemID
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 WFCModuleSet
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 WFCBuildingPreset
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean AutoCollision
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public GcBuildingClassification Classification
	{
		get => GetValue<GcBuildingClassification>();
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public VirtualArray<Int32> ClusterLayouts
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 8));
		set => TrySetValue<Int32>(value);
	}

	public Int32 ClusterLayoutCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ClusterSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkNoiseFlattenOptions FlattenType
	{
		get => GetValue<TkNoiseFlattenOptions>();
		set => TrySetValue<TkNoiseFlattenOptions>(value);
	}

	public Boolean GivesShelter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlignToNormal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LowerIntoGround
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxXZRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
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

	public Int32 InstanceID
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector3f AABBMin
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f AABBMax
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean BuildingSizeCalculated
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBuildingSpawnData(long address) : base(address)
	{

	}
}
