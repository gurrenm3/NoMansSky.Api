using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionIsFrigateFlybyActive : NMSTemplate
{
	public GcFrigateFlybyType FrigateFlybyType
	{
		get => GetValue<GcFrigateFlybyType>();
		set => TrySetValue<GcFrigateFlybyType>(value);
	}

	public GcMissionConditionIsFrigateFlybyActive(long address) : base(address)
	{

	}
}
