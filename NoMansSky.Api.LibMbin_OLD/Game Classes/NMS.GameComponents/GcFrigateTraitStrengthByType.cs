using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateTraitStrengthByType : NMSTemplate
{
	public VirtualArray<GcFrigateTraitStrengthValues> FrigateStatType
	{
		get => cache.GetOrAddValue(new VirtualArray<GcFrigateTraitStrengthValues>(address + GetOffset(), 11));
		set => TrySetValue<GcFrigateTraitStrengthValues>(value);
	}

	public GcFrigateTraitStrengthByType(long address) : base(address)
	{

	}
}
