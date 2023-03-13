using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDissolveEffectComponentData : NMSTemplate
{
	public Single DissolveBeginHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DissolveEndHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDissolveEffectComponentData(long address) : base(address)
	{

	}
}
