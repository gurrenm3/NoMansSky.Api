using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHeavyAirColourData : NMSTemplate
{
	public Colour Colour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour Colour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcHeavyAirColourData(long address) : base(address)
	{

	}
}
