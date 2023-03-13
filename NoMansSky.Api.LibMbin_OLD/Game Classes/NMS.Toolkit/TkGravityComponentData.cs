using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkGravityComponentData : NMSTemplate
{
	public Single Strength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FalloffRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkGravityComponentData(long address) : base(address)
	{

	}
}
