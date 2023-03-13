using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourWaitData : NMSTemplate
{
	public Single Seconds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBehaviourWaitData(long address) : base(address)
	{

	}
}
