using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiRectanglePulseEffect : NMSTemplate
{
	public Single PulseWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType PulseAlphaCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType PulseSizeCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkNGuiRectanglePulseEffect(long address) : base(address)
	{

	}
}
