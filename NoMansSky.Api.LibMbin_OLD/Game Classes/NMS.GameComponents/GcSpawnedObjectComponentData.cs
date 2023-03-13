using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpawnedObjectComponentData : NMSTemplate
{
	public Boolean CanBeTeleported
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSpawnedObjectComponentData(long address) : base(address)
	{

	}
}
