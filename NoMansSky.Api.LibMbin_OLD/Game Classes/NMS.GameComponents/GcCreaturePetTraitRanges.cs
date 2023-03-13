using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreaturePetTraitRanges : NMSTemplate
{
	public VirtualArray<GcCreaturePetTraitRange> TraitRanges
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCreaturePetTraitRange>(address + GetOffset(), 3));
		set => TrySetValue<GcCreaturePetTraitRange>(value);
	}

	public GcCreaturePetTraitRanges(long address) : base(address)
	{

	}
}
