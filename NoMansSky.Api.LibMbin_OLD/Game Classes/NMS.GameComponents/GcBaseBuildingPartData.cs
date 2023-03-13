using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPartData : NMSTemplate
{
	public NMSString0x20A PartID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcBaseBuildingPartStyle Style
	{
		get => GetValue<GcBaseBuildingPartStyle>();
		set => TrySetValue<GcBaseBuildingPartStyle>(value);
	}

	public TkMagicModelData MagicData
	{
		get => GetValue<TkMagicModelData>();
		set => TrySetValue<TkMagicModelData>(value);
	}

	public UInt32 NodesCost
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 TimeCost
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 PhysicsCost
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 MeshesCost
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 InstanceNodesCost
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 InstanceTimeCost
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 InstanceMeshesCost
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt64 LastProfiledTimestamp
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 InstanceLastProfiledTimestamp
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcBaseBuildingPartData(long address) : base(address)
	{

	}
}
