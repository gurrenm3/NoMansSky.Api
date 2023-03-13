using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTradeCategory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcTradeCategory.TradeCategoryEnum TradeCategory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTradeCategory.TradeCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTradeCategory.TradeCategoryEnum>(value);
	}

	public GcTradeCategory(long address) : base(address)
	{

	}
}
