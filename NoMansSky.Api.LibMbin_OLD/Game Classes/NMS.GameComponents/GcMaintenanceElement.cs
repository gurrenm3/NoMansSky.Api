using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMaintenanceElement : NMSTemplate
{
	public GcMaintenanceElementGroups ItemGroupOverride
	{
		get => GetValue<GcMaintenanceElementGroups>();
		set => TrySetValue<GcMaintenanceElementGroups>(value);
	}

	public GcInventoryType Type
	{
		get => GetValue<GcInventoryType>();
		set => TrySetValue<GcInventoryType>(value);
	}

	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single MinRandAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRandAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxCapacity
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single AmountEmptyTimePeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcMaintenanceElement.UpdateTypeEnum UpdateType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMaintenanceElement.UpdateTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMaintenanceElement.UpdateTypeEnum>(value);
	}

	public Int32 DamagedAfterTimePeriodMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 DamagedAfterTimePeriodMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.GameComponents.GcMaintenanceElement.DamageStatusEnum DamageStatus
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMaintenanceElement.DamageStatusEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMaintenanceElement.DamageStatusEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcMaintenanceElement.CompletionRequirementEnum CompletionRequirement
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMaintenanceElement.CompletionRequirementEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMaintenanceElement.CompletionRequirementEnum>(value);
	}

	public GcMaintenanceElement(long address) : base(address)
	{

	}
}
