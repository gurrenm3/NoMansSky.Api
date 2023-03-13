using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionUsingPortal : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionUsingPortal.PortalTypeEnum PortalType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionUsingPortal.PortalTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionUsingPortal.PortalTypeEnum>(value);
	}

	public GcMissionConditionUsingPortal(long address) : base(address)
	{

	}
}
