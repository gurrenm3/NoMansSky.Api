using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLightProperties : NMSTemplate
{
	public Colour SunColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour LightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BounceColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcLightProperties(long address) : base(address)
	{

	}
}
