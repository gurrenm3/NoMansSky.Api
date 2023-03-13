using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcByteBeatSwitchComponentData : NMSTemplate
{
	public Single Temp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcByteBeatSwitchComponentData(long address) : base(address)
	{

	}
}
