using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTradingClass : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcTradingClass.TradingClassEnum TradingClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTradingClass.TradingClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTradingClass.TradingClassEnum>(value);
	}

	public GcTradingClass(long address) : base(address)
	{

	}
}
