using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFleetExpeditionSaveData : NMSTemplate
{
	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public UInt64 UA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Vector3f SpawnPosition
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f TerminalPosition
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single SpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<NMSString0x10> Powerups
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x100 CustomName
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x10 InterventionEventMissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public UInt64 StartTime
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 PauseTime
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 TimeOfLastUAChange
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Int32 NextEventToTrigger
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcExpeditionCategory ExpeditionCategory
	{
		get => GetValue<GcExpeditionCategory>();
		set => TrySetValue<GcExpeditionCategory>(value);
	}

	public GcExpeditionDuration ExpeditionDuration
	{
		get => GetValue<GcExpeditionDuration>();
		set => TrySetValue<GcExpeditionDuration>(value);
	}

	public VirtualList<Int32> ActiveFrigateIndices
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> DamagedFrigateIndices
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> DestroyedFrigateIndices
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> AllFrigateIndices
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumberOfSuccessfulEventsThisExpedition
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumberOfFailedEventsThisExpedition
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcExpeditionEventSaveData> Events
	{
		get => cache.GetOrAddValue(new VirtualList<GcExpeditionEventSaveData>(address + GetOffset()));
		set => TrySetValue<GcExpeditionEventSaveData>(value);
	}

	public Boolean InterventionPhoneCallActivated
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcFleetExpeditionSaveData(long address) : base(address)
	{

	}
}
