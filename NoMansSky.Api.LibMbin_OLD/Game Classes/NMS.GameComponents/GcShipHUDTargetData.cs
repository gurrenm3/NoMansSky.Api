using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipHUDTargetData : NMSTemplate
{
	public GcShipHUDTargetIconData IconData
	{
		get => GetValue<GcShipHUDTargetIconData>();
		set => TrySetValue<GcShipHUDTargetIconData>(value);
	}

	public NMSString0x80 Arrow
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single IconSizeIn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IconMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IconMaxSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IconSizeScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowMinFadeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowMaxSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour BaseColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single ActiveDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ActivateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GlowAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HighlightTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitPulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitWhiteOut
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour LockColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single PoliceColourFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour PoliceColour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour PoliceColour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ThreatColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcShipHUDTargetData(long address) : base(address)
	{

	}
}
