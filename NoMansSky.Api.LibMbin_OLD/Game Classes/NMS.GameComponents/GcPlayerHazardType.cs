using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerHazardType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlayerHazardType.HazardEnum Hazard
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerHazardType.HazardEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerHazardType.HazardEnum>(value);
	}

	public GcPlayerHazardType(long address) : base(address)
	{

	}
}
