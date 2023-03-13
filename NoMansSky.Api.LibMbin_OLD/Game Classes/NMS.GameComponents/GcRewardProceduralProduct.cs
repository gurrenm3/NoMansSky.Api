using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardProceduralProduct : NMSTemplate
{
	public GcProceduralProductCategory Type
	{
		get => GetValue<GcProceduralProductCategory>();
		set => TrySetValue<GcProceduralProductCategory>(value);
	}

	public NMSString0x20A OSDMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean SubIfPlayerAlreadyHasOne
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OverrideRarity
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRarity Rarity
	{
		get => GetValue<GcRarity>();
		set => TrySetValue<GcRarity>(value);
	}

	public GcRewardProceduralProduct(long address) : base(address)
	{

	}
}
