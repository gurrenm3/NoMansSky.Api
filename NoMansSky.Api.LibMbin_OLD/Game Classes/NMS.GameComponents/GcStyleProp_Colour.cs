using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStyleProp_Colour : NMSTemplate
{
	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcStyleProp_Colour(long address) : base(address)
	{

	}
}
