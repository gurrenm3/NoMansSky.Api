using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVehicleComponentData : NMSTemplate
{
	public GcVehicleType Class
	{
		get => GetValue<GcVehicleType>();
		set => TrySetValue<GcVehicleType>(value);
	}

	public NMSString0x10 VehicleType
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 Cockpit
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single MaxHeadTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeadPitchUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeadPitchDown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTurretAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoVFixedDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 BaseHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkModelResource WheelModel
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public GcVehicleComponentData(long address) : base(address)
	{

	}
}
