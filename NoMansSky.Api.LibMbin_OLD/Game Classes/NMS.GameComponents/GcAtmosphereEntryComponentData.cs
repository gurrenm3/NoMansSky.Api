using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtmosphereEntryComponentData : NMSTemplate
{
	public Boolean AutoEntry
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single EntryTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EntryOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EditTerrainRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 ImpactEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 FlareEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcAtmosphereEntryComponentData(long address) : base(address)
	{

	}
}
