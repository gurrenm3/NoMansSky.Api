using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterCustomisationTextureOptionData : NMSTemplate
{
	public NMSString0x10 TextureOptionGroupName
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A TextureOptionName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcCharacterCustomisationTextureOptionData(long address) : base(address)
	{

	}
}
