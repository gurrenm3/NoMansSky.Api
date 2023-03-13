using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSetNexusExitWarpTargetToFireteamMemberUA : NMSTemplate
{
	public Int32 FireteamMemberIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRewardSetNexusExitWarpTargetToFireteamMemberUA(long address) : base(address)
	{

	}
}
