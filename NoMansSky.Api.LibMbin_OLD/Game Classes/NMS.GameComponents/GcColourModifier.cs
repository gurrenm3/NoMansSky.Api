using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcColourModifier : NMSTemplate
{
	public Boolean ForceColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour ForceColourTo
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single OffsetSaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MultiplySaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MultiplyValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcColourModifier(long address) : base(address)
	{

	}
}
