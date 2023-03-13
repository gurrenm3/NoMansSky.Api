using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTriggerActionComponentData : NMSTemplate
{
	public Boolean HideModel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean StartInactive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcActionTriggerState> States
	{
		get => cache.GetOrAddValue(new VirtualList<GcActionTriggerState>(address + GetOffset()));
		set => TrySetValue<GcActionTriggerState>(value);
	}

	public Boolean Persistent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 PersistentState
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean ResetShotTimeOnStateChange
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LinkStateToBaseGrid
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcTriggerActionComponentData(long address) : base(address)
	{

	}
}
