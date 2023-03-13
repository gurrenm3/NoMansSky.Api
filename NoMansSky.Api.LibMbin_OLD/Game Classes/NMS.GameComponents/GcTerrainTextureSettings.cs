using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTerrainTextureSettings : NMSTemplate
{
	public Single Brightness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Contrast
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Specular
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTerrainTextureSettings(long address) : base(address)
	{

	}
}
