using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkProceduralTextureList : NMSTemplate
{
	public VirtualArray<TkProceduralTextureLayer> Layers
	{
		get => cache.GetOrAddValue(new VirtualArray<TkProceduralTextureLayer>(address + GetOffset(), 8));
		set => TrySetValue<TkProceduralTextureLayer>(value);
	}

	public TkProceduralTextureList(long address) : base(address)
	{

	}
}
