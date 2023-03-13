using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyRenderAnostreakData : NMSTemplate
{
	public Colour OuterColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour InnerColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single VerticalCompression
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizontalScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Contrast
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcGalaxyRenderAnostreakData(long address) : base(address)
	{

	}
}
