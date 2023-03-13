using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHazardValueTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcHazardValueTypes.HazardValueEnum HazardValue
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcHazardValueTypes.HazardValueEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcHazardValueTypes.HazardValueEnum>(value);
	}

	public GcHazardValueTypes(long address) : base(address)
	{

	}
}
