using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSubstanceSecondaryBiome : NMSTemplate
{
	public VirtualArray<GcSubstanceSecondary> SecondarySubstanceByBiome
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSubstanceSecondary>(address + GetOffset(), 16));
		set => TrySetValue<GcSubstanceSecondary>(value);
	}

	public GcSubstanceSecondaryBiome(long address) : base(address)
	{

	}
}
