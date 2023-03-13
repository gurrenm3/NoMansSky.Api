using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDoShipFlybyClose : NMSTemplate
{
	public Single LockOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockSpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean StayCloseAtLowSpeed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HailingBehaviour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcDoShipFlybyClose(long address) : base(address)
	{

	}
}
