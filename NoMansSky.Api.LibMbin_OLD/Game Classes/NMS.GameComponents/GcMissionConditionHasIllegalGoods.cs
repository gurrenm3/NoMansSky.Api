using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasIllegalGoods : NMSTemplate
{
	public Boolean IncludeNipNip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionHasIllegalGoods(long address) : base(address)
	{

	}
}
