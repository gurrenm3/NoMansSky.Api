using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionSystemStarClass : NMSTemplate
{
	public GcGalaxyStarTypes Class
	{
		get => GetValue<GcGalaxyStarTypes>();
		set => TrySetValue<GcGalaxyStarTypes>(value);
	}

	public GcMissionConditionSystemStarClass(long address) : base(address)
	{

	}
}
