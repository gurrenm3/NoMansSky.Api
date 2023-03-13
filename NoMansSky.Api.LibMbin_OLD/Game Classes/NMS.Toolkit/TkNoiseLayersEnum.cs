using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseLayersEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkNoiseLayersEnum.NoiseLayerTypesEnum NoiseLayerTypes
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNoiseLayersEnum.NoiseLayerTypesEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNoiseLayersEnum.NoiseLayerTypesEnum>(value);
	}

	public TkNoiseLayersEnum(long address) : base(address)
	{

	}
}
