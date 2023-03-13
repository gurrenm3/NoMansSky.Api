using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionOnPlanetWithSandwormsOverriden : NMSTemplate
{
	public Boolean AllowInShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AcceptMatchingSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionOnPlanetWithSandwormsOverriden(long address) : base(address)
	{

	}
}
