using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTerrainTexture : NMSTemplate
{
	public NMSString0x80 DiffuseTexture
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 NormalMap
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<GcTerrainTextureSettings> TextureConfig
	{
		get => cache.GetOrAddValue(new VirtualArray<GcTerrainTextureSettings>(address + GetOffset(), 12));
		set => TrySetValue<GcTerrainTextureSettings>(value);
	}

	public GcTerrainTexture(long address) : base(address)
	{

	}
}
