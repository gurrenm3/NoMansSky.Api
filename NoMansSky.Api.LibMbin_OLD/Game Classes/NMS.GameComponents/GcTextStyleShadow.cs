using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTextStyleShadow : NMSTemplate
{
	public Colour ShadowColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector2f ShadowOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcTextStyleShadow(long address) : base(address)
	{

	}
}
