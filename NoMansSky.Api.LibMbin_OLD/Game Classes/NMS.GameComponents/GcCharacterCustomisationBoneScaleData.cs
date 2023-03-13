using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterCustomisationBoneScaleData : NMSTemplate
{
	public NMSString0x10 BoneName
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCharacterCustomisationBoneScaleData(long address) : base(address)
	{

	}
}
