using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateTraitData : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A DisplayName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcFrigateStatType FrigateStatType
	{
		get => GetValue<GcFrigateStatType>();
		set => TrySetValue<GcFrigateStatType>(value);
	}

	public GcFrigateTraitStrength Strength
	{
		get => GetValue<GcFrigateTraitStrength>();
		set => TrySetValue<GcFrigateTraitStrength>(value);
	}

	public VirtualArray<Int32> ChanceOfBeingOffered
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 8));
		set => TrySetValue<Int32>(value);
	}

	public GcFrigateTraitData(long address) : base(address)
	{

	}
}
