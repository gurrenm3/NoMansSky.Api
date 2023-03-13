using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTableEntry : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<GcRewardTableCategory> Rarities
	{
		get => cache.GetOrAddValue(new VirtualArray<GcRewardTableCategory>(address + GetOffset(), 3));
		set => TrySetValue<GcRewardTableCategory>(value);
	}

	public GcRewardTableEntry(long address) : base(address)
	{

	}
}
