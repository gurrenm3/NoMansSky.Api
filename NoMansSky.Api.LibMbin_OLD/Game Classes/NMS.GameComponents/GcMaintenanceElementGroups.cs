using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMaintenanceElementGroups : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMaintenanceElementGroups.MaintenanceGroupEnum MaintenanceGroup
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMaintenanceElementGroups.MaintenanceGroupEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMaintenanceElementGroups.MaintenanceGroupEnum>(value);
	}

	public GcMaintenanceElementGroups(long address) : base(address)
	{

	}
}
