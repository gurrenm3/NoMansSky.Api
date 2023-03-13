using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterSyncComponentData : NMSTemplate
{
	public Boolean Dummy
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcFreighterSyncComponentData(long address) : base(address)
	{

	}
}
