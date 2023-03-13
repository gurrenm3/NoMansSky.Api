using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateStats : NMSTemplate
{
	public VirtualArray<GcFrigateStatRange> Stats
	{
		get => cache.GetOrAddValue(new VirtualArray<GcFrigateStatRange>(address + GetOffset(), 11));
		set => TrySetValue<GcFrigateStatRange>(value);
	}

	public NMSString0x10 InitialTrait
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcFrigateStats(long address) : base(address)
	{

	}
}
