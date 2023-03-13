using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSolarSystemLocatorChoice : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSolarSystemLocatorChoice.ChoiceEnum Choice
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSolarSystemLocatorChoice.ChoiceEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSolarSystemLocatorChoice.ChoiceEnum>(value);
	}

	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcSolarSystemLocatorTypes Type
	{
		get => GetValue<GcSolarSystemLocatorTypes>();
		set => TrySetValue<GcSolarSystemLocatorTypes>(value);
	}

	public Int32 Index
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSolarSystemLocatorChoice(long address) : base(address)
	{

	}
}
