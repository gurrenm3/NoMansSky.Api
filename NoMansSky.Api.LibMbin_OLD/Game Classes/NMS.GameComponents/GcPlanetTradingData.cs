using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetTradingData : NMSTemplate
{
	public GcWealthClass WealthClass
	{
		get => GetValue<GcWealthClass>();
		set => TrySetValue<GcWealthClass>(value);
	}

	public GcTradingClass TradingClass
	{
		get => GetValue<GcTradingClass>();
		set => TrySetValue<GcTradingClass>(value);
	}

	public GcPlanetTradingData(long address) : base(address)
	{

	}
}
