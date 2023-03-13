using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcColouriseComponentData : NMSTemplate
{
	public Colour PrimaryColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SecondaryColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TernaryColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour QuaternaryColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcColouriseComponentData(long address) : base(address)
	{

	}
}
