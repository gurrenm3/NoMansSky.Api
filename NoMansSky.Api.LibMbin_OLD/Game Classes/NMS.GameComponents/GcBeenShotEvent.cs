using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBeenShotEvent : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBeenShotEvent.ShotByEnum ShotBy
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBeenShotEvent.ShotByEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBeenShotEvent.ShotByEnum>(value);
	}

	public Int32 DamageThreshold
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single HealthThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBeenShotEvent(long address) : base(address)
	{

	}
}
