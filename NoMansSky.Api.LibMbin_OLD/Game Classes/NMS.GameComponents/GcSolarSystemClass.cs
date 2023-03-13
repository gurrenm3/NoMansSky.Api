using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSolarSystemClass : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSolarSystemClass.SolarSystemClassEnum SolarSystemClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSolarSystemClass.SolarSystemClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSolarSystemClass.SolarSystemClassEnum>(value);
	}

	public GcSolarSystemClass(long address) : base(address)
	{

	}
}
