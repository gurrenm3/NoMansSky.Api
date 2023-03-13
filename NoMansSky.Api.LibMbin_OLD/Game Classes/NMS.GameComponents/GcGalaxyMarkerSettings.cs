using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyMarkerSettings : NMSTemplate
{
	public VirtualArray<Colour> Colours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 3));
		set => TrySetValue<Colour>(value);
	}

	public Colour OutlineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single OutlineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 EdgeCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single RotationBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LineWidthFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SizeScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadiusFixed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadiusMinimum
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadiusBaseOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadiusEdge
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 Icon
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Vector2f IconSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public NMSString0x20 MarkerLabel
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Vector2f TimeScaleRange
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcGalaxyMarkerSettings(long address) : base(address)
	{

	}
}
