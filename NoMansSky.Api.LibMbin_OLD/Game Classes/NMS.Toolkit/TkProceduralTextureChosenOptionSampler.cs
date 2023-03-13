using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkProceduralTextureChosenOptionSampler : NMSTemplate
{
	public VirtualList<TkProceduralTextureChosenOption> Options
	{
		get => cache.GetOrAddValue(new VirtualList<TkProceduralTextureChosenOption>(address + GetOffset()));
		set => TrySetValue<TkProceduralTextureChosenOption>(value);
	}

	public TkProceduralTextureChosenOptionSampler(long address) : base(address)
	{

	}
}
