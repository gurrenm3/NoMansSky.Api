using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCurrency : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCurrency.CurrencyEnum Currency
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCurrency.CurrencyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCurrency.CurrencyEnum>(value);
	}

	public GcCurrency(long address) : base(address)
	{

	}
}
