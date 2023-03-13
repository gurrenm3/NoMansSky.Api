using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerCharacterAnimationOverrideData : NMSTemplate
{
	public NMSString0x10 AnimName
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPlayerCharacterIKOverrideData Data
	{
		get => GetValue<GcPlayerCharacterIKOverrideData>();
		set => TrySetValue<GcPlayerCharacterIKOverrideData>(value);
	}

	public GcPlayerCharacterAnimationOverrideData(long address) : base(address)
	{

	}
}
