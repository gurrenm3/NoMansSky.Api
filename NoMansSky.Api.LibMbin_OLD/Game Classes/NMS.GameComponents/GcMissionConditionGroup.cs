using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionGroup : NMSTemplate
{
	public GcMissionConditionTest ConditionTest
	{
		get => GetValue<GcMissionConditionTest>();
		set => TrySetValue<GcMissionConditionTest>(value);
	}

	public VirtualList<NMSTemplate> Conditions
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcMissionConditionGroup(long address) : base(address)
	{

	}
}
