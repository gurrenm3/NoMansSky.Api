using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAIShipSpawnData : NMSTemplate
{
	public NMSString0x20A Message
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A CombatMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A OSDMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public TkInputEnum Shortcut
	{
		get => GetValue<TkInputEnum>();
		set => TrySetValue<TkInputEnum>(value);
	}

	public Boolean WarpIn
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAISpaceshipRoles Role
	{
		get => GetValue<GcAISpaceshipRoles>();
		set => TrySetValue<GcAISpaceshipRoles>(value);
	}

	public Single MinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f Scale
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public NMSString0x10 Reward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A RewardMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcAIShipSpawnMarkerData MarkerData
	{
		get => GetValue<GcAIShipSpawnMarkerData>();
		set => TrySetValue<GcAIShipSpawnMarkerData>(value);
	}

	public Boolean AttackFreighter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector2f Spread
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f Count
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f StartTime
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public libMBIN.NMS.GameComponents.GcAIShipSpawnData.SpawnShapeEnum SpawnShape
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAIShipSpawnData.SpawnShapeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAIShipSpawnData.SpawnShapeEnum>(value);
	}

	public GcShipAIPerformanceArray Performances
	{
		get => GetValue<GcShipAIPerformanceArray>();
		set => TrySetValue<GcShipAIPerformanceArray>(value);
	}

	public VirtualList<GcAIShipSpawnData> ChildSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public GcAIShipSpawnData(long address) : base(address)
	{

	}
}
