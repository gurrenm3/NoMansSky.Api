using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionCategory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionCategory.MissionCategoryEnum MissionCategory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionCategory.MissionCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionCategory.MissionCategoryEnum>(value);
	}

	public GcMissionCategory(long address) : base(address)
	{

	}
}
