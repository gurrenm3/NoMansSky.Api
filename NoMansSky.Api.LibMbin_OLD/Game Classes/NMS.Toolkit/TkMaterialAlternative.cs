using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMaterialAlternative : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkMaterialAlternative.TextureTypeEnum TextureType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkMaterialAlternative.TextureTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkMaterialAlternative.TextureTypeEnum>(value);
	}

	public NMSString0x80 File
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x20A MaterialAlternativeId
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public TkMaterialAlternative(long address) : base(address)
	{

	}
}
