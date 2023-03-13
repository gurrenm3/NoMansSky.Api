using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBasePlacementRule : NMSTemplate
{
	public VirtualList<NMSTemplate> Conditions
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public NMSString0x80 PositionLocator
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x20A PartID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean ORConditions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcBasePlacementRule.TwinCriteriaEnum TwinCriteria
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBasePlacementRule.TwinCriteriaEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBasePlacementRule.TwinCriteriaEnum>(value);
	}

	public GcBasePlacementRule(long address) : base(address)
	{

	}
}
