using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPalette : NMSTemplate
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

	public NMSString0x20A Name
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Id
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public libMBIN.NMS.GameComponents.GcBaseBuildingPalette.SwatchPrimaryColourEnum SwatchPrimaryColour
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseBuildingPalette.SwatchPrimaryColourEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseBuildingPalette.SwatchPrimaryColourEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcBaseBuildingPalette.SwatchSecondaryColourEnum SwatchSecondaryColour
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseBuildingPalette.SwatchSecondaryColourEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseBuildingPalette.SwatchSecondaryColourEnum>(value);
	}

	public GcBaseBuildingPalette(long address) : base(address)
	{

	}
}
