using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRainbowType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRainbowType.RainbowTypeEnum RainbowType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRainbowType.RainbowTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRainbowType.RainbowTypeEnum>(value);
	}

	public GcRainbowType(long address) : base(address)
	{

	}
}
