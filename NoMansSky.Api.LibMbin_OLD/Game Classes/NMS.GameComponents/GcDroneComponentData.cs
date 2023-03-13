using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDroneComponentData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPrimaryAxis Axis
	{
		get => GetValue<GcPrimaryAxis>();
		set => TrySetValue<GcPrimaryAxis>(value);
	}

	public Single Scaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureHealthData Health
	{
		get => GetValue<GcCreatureHealthData>();
		set => TrySetValue<GcCreatureHealthData>(value);
	}

	public VirtualList<NMSString0x10> ProjectileChoices
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcDroneGun> Guns
	{
		get => cache.GetOrAddValue(new VirtualList<GcDroneGun>(address + GetOffset()));
		set => TrySetValue<GcDroneGun>(value);
	}

	public GcDroneComponentData(long address) : base(address)
	{

	}
}
