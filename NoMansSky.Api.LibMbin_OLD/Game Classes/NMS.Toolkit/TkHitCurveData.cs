using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkHitCurveData : NMSTemplate
{
	public Single Time
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkInOutCurve Curve
	{
		get => GetValue<TkInOutCurve>();
		set => TrySetValue<TkInOutCurve>(value);
	}

	public TkHitCurveData(long address) : base(address)
	{

	}
}
