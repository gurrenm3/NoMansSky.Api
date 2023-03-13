using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkProceduralTextureLayer : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 Group
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean SelectToMatchBase
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<TkProceduralTexture> Textures
	{
		get => cache.GetOrAddValue(new VirtualList<TkProceduralTexture>(address + GetOffset()));
		set => TrySetValue<TkProceduralTexture>(value);
	}

	public TkProceduralTextureLayer(long address) : base(address)
	{

	}
}
