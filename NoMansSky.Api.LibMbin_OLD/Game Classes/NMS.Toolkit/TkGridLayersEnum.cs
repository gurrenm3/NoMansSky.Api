using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkGridLayersEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkGridLayersEnum.GridLayerTypesEnum GridLayerTypes
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGridLayersEnum.GridLayerTypesEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGridLayersEnum.GridLayerTypesEnum>(value);
	}

	public TkGridLayersEnum(long address) : base(address)
	{

	}
}
