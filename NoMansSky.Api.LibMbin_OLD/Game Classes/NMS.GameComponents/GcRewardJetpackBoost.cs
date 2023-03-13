using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardJetpackBoost : NMSTemplate
{
	public Single Duration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ForwardBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IgnitionBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcRewardJetpackBoost(long address) : base(address)
	{

	}
}
