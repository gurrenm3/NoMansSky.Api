using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkCoordinateOrientation : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkCoordinateOrientation.CoordinateOrientationEnum CoordinateOrientation
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkCoordinateOrientation.CoordinateOrientationEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkCoordinateOrientation.CoordinateOrientationEnum>(value);
	}

	public TkCoordinateOrientation(long address) : base(address)
	{

	}
}
