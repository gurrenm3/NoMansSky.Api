using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateTraitStrengthValues : NMSTemplate
{
	public VirtualArray<Int32> StatAlteration
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 10));
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20A StatLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean StatDisplaysPositive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcFrigateTraitStrengthValues(long address) : base(address)
	{

	}
}
