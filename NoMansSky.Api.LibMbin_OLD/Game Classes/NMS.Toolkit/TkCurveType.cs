using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkCurveType : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkCurveType.CurveEnum Curve
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkCurveType.CurveEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkCurveType.CurveEnum>(value);
	}

	public TkCurveType(long address) : base(address)
	{

	}
}
