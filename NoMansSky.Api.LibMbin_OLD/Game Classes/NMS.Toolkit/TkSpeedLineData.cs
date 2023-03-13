using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkSpeedLineData : NMSTemplate
{
	public NMSString0x80 Material
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 NumberOfParticles
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Length
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RemoveCylinderRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Width
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Alpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinVisibleSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxVisibleSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Lifetime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ColourOrigin
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ColourEnd
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public libMBIN.NMS.Toolkit.TkSpeedLineData.LinesPositionEnum LinesPosition
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkSpeedLineData.LinesPositionEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkSpeedLineData.LinesPositionEnum>(value);
	}

	public TkSpeedLineData(long address) : base(address)
	{

	}
}
