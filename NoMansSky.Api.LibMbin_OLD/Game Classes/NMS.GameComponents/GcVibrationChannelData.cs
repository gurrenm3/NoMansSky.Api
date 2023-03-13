using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVibrationChannelData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<GcVibrationData> Data
	{
		get => cache.GetOrAddValue(new VirtualArray<GcVibrationData>(address + GetOffset(), 2));
		set => TrySetValue<GcVibrationData>(value);
	}

	public GcVibrationChannelData(long address) : base(address)
	{

	}
}
