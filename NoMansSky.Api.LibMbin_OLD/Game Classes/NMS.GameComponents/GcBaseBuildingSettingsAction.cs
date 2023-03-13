using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingSettingsAction : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBaseBuildingSettingsAction.UseCorePartsOnlyEnum UseCorePartsOnly
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseBuildingSettingsAction.UseCorePartsOnlyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseBuildingSettingsAction.UseCorePartsOnlyEnum>(value);
	}

	public TkGraphicsDetailTypes MaxAffectedDetail
	{
		get => GetValue<TkGraphicsDetailTypes>();
		set => TrySetValue<TkGraphicsDetailTypes>(value);
	}

	public GcBaseBuildingSettingsAction(long address) : base(address)
	{

	}
}
