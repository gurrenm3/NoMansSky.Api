using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMaintenanceGroupEntry : NMSTemplate
{
	public GcInventoryType Type
	{
		get => GetValue<GcInventoryType>();
		set => TrySetValue<GcInventoryType>(value);
	}

	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single ProbabilityWeighting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMaintenanceGroupEntry(long address) : base(address)
	{

	}
}
