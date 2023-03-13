using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureHoverTintableEffect : NMSTemplate
{
	public NMSString0x100 EffectNode
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Single LightStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TintStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour TintColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcCreatureHoverTintableEffect(long address) : base(address)
	{

	}
}
