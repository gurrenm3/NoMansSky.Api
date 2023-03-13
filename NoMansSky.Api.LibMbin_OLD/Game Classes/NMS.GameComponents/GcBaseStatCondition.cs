using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseStatCondition : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBaseStatCondition.BaseStatEnum BaseStat
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseStatCondition.BaseStatEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseStatCondition.BaseStatEnum>(value);
	}

	public Boolean StatValue
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBaseStatCondition(long address) : base(address)
	{

	}
}
