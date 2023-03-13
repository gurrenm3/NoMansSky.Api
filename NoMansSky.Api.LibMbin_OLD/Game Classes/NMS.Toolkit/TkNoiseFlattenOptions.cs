using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseFlattenOptions : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkNoiseFlattenOptions.FlatteningEnum Flattening
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNoiseFlattenOptions.FlatteningEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNoiseFlattenOptions.FlatteningEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkNoiseFlattenOptions.WaterPlacementEnum WaterPlacement
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNoiseFlattenOptions.WaterPlacementEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNoiseFlattenOptions.WaterPlacementEnum>(value);
	}

	public TkNoiseFlattenOptions(long address) : base(address)
	{

	}
}
