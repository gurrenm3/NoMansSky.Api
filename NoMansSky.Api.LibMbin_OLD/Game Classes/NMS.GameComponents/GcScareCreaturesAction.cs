using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScareCreaturesAction : NMSTemplate
{
	public Single HearRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScareCreaturesAction(long address) : base(address)
	{

	}
}
