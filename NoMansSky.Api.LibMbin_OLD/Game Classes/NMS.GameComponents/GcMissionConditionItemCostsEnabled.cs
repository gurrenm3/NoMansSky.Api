using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionItemCostsEnabled : NMSTemplate
{
	public GcItemNeedPurpose Purpose
	{
		get => GetValue<GcItemNeedPurpose>();
		set => TrySetValue<GcItemNeedPurpose>(value);
	}

	public Boolean Enabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionItemCostsEnabled(long address) : base(address)
	{

	}
}
