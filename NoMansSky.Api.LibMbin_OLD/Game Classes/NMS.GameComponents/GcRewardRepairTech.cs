using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardRepairTech : NMSTemplate
{
	public GcTechnologyCategory Category
	{
		get => GetValue<GcTechnologyCategory>();
		set => TrySetValue<GcTechnologyCategory>(value);
	}

	public GcRewardRepairTech(long address) : base(address)
	{

	}
}
