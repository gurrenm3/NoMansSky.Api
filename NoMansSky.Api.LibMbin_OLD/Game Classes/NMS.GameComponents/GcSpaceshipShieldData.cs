using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceshipShieldData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Health
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LevelledExtraHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single RechargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RechargeDelayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSpaceshipShieldData(long address) : base(address)
	{

	}
}
