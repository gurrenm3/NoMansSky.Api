using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationTextureOptions : NMSTemplate
{
	public VirtualList<GcCustomisationTextureOption> TextureOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationTextureOption>(address + GetOffset()));
		set => TrySetValue<GcCustomisationTextureOption>(value);
	}

	public GcCustomisationTextureOptions(long address) : base(address)
	{

	}
}
