using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkInteractiveControlData : NMSTemplate
{
	public NMSString0x20 Id
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x10 RewardId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Cooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkInteractiveControlData(long address) : base(address)
	{

	}
}
