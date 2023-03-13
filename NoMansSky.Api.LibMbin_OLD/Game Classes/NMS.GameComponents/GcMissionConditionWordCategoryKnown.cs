using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionWordCategoryKnown : NMSTemplate
{
	public GcWordCategoryTableEnum Category
	{
		get => GetValue<GcWordCategoryTableEnum>();
		set => TrySetValue<GcWordCategoryTableEnum>(value);
	}

	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public GcMissionConditionWordCategoryKnown(long address) : base(address)
	{

	}
}
