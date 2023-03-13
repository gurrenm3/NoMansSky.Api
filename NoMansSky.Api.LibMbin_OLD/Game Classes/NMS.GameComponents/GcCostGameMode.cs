using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostGameMode : NMSTemplate
{
	public Boolean InvertMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcGameMode Mode
	{
		get => GetValue<GcGameMode>();
		set => TrySetValue<GcGameMode>(value);
	}

	public NMSString0x20A CostStringCantAfford
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcCostGameMode(long address) : base(address)
	{

	}
}
