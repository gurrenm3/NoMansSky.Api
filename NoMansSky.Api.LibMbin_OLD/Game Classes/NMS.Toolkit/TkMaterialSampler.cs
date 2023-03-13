using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMaterialSampler : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x80 Map
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean IsCube
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseCompression
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseMipMaps
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsSRGB
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A MaterialAlternativeId
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public libMBIN.NMS.Toolkit.TkMaterialSampler.TextureAddressModeEnum TextureAddressMode
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkMaterialSampler.TextureAddressModeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkMaterialSampler.TextureAddressModeEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkMaterialSampler.TextureFilterModeEnum TextureFilterMode
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkMaterialSampler.TextureFilterModeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkMaterialSampler.TextureFilterModeEnum>(value);
	}

	public Int32 Anisotropy
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkMaterialSampler(long address) : base(address)
	{

	}
}
