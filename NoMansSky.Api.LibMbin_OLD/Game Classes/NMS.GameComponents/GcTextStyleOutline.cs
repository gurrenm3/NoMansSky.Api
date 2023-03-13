using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTextStyleOutline : NMSTemplate
{
	public Colour OutlineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector2f OutlineOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcTextStyleOutline(long address) : base(address)
	{

	}
}
