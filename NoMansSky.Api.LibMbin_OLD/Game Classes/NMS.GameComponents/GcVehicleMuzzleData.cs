using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVehicleMuzzleData : NMSTemplate
{
	public VirtualArray<NMSString0x10> MuzzleFlashDataID
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcVehicleMuzzleData(long address) : base(address)
	{

	}
}
