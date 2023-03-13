using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionEventRequiresRGB : NMSTemplate
{
	public NMSString0x20A Event
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean IgnoreIfPlayerHasAccess
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcGalaxyStarTypes StarType
	{
		get => GetValue<GcGalaxyStarTypes>();
		set => TrySetValue<GcGalaxyStarTypes>(value);
	}

	public GcMissionConditionEventRequiresRGB(long address) : base(address)
	{

	}
}
