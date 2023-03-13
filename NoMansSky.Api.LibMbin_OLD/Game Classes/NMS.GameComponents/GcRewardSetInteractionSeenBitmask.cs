using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSetInteractionSeenBitmask : NMSTemplate
{
	public GcInteractionType InteractionType
	{
		get => GetValue<GcInteractionType>();
		set => TrySetValue<GcInteractionType>(value);
	}

	public Int32 OverrideIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 Stat
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardSetInteractionSeenBitmask(long address) : base(address)
	{

	}
}
