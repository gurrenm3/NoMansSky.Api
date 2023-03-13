using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostWordKnowledge : NMSTemplate
{
	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public libMBIN.NMS.GameComponents.GcCostWordKnowledge.RequirementEnum Requirement
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCostWordKnowledge.RequirementEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCostWordKnowledge.RequirementEnum>(value);
	}

	public GcCostWordKnowledge(long address) : base(address)
	{

	}
}
