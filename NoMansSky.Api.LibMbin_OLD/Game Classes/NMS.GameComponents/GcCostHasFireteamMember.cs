using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostHasFireteamMember : NMSTemplate
{
	public Int32 Index
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCostHasFireteamMember(long address) : base(address)
	{

	}
}
