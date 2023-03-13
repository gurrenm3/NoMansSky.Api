using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingDefinitionData : NMSTemplate
{
	public TkNoiseFlattenOptions FlattenType
	{
		get => GetValue<TkNoiseFlattenOptions>();
		set => TrySetValue<TkNoiseFlattenOptions>(value);
	}

	public NMSString0x10 ClusterLayout
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single ClusterSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> Density
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 6));
		set => TrySetValue<Single>(value);
	}

	public Boolean EnabledWhenPlanetHasNoNPCs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 NumOverridesToGenerate
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumModelsToGenerate
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20A TextureNameHint
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single OverrideRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean GivesShelter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
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

	public GcBuildingDefinitionData(long address) : base(address)
	{

	}
}
