using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSolarSystemLocatorTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSolarSystemLocatorTypes.LocatorTypeEnum LocatorType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSolarSystemLocatorTypes.LocatorTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSolarSystemLocatorTypes.LocatorTypeEnum>(value);
	}

	public GcSolarSystemLocatorTypes(long address) : base(address)
	{

	}
}
