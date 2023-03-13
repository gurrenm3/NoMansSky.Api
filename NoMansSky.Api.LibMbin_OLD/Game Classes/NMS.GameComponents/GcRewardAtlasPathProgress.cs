using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardAtlasPathProgress : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardAtlasPathProgress.AtlasPathProgressTypeEnum AtlasPathProgressType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardAtlasPathProgress.AtlasPathProgressTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardAtlasPathProgress.AtlasPathProgressTypeEnum>(value);
	}

	public GcRewardAtlasPathProgress(long address) : base(address)
	{

	}
}
