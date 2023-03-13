using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCInteractiveObjectStateTransition : NMSTemplate
{
	public NMSString0x10 NewState
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 RequireEvent
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 RequireLocator
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcNPCInteractiveObjectStateTransition.RequireModeEnum RequireMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCInteractiveObjectStateTransition.RequireModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCInteractiveObjectStateTransition.RequireModeEnum>(value);
	}

	public VirtualList<NMSString0x10> ExcludeTags
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcNPCInteractiveObjectStateTransition(long address) : base(address)
	{

	}
}
