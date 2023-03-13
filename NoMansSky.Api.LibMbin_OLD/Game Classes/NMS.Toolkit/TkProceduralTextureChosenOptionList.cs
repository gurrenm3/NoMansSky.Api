using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkProceduralTextureChosenOptionList : NMSTemplate
{
	public VirtualList<TkProceduralTextureChosenOptionSampler> Samplers
	{
		get => cache.GetOrAddValue(new VirtualList<TkProceduralTextureChosenOptionSampler>(address + GetOffset()));
		set => TrySetValue<TkProceduralTextureChosenOptionSampler>(value);
	}

	public TkProceduralTextureChosenOptionList(long address) : base(address)
	{

	}
}
