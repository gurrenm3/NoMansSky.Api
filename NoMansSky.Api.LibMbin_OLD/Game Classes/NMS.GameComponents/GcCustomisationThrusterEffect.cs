using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationThrusterEffect : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 LinkedSpecialID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A Tip
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean AllowedInSeasonalDefaults
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour LightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public VirtualList<GcCustomisationThrusterJet> Jets
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationThrusterJet>(address + GetOffset()));
		set => TrySetValue<GcCustomisationThrusterJet>(value);
	}

	public GcCustomisationThrusterEffect(long address) : base(address)
	{

	}
}
