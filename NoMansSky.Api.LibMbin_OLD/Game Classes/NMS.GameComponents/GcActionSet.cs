using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcActionSet : NMSTemplate
{
	public GcActionSetType Type
	{
		get => GetValue<GcActionSetType>();
		set => TrySetValue<GcActionSetType>(value);
	}

	public GcActionUseType Status
	{
		get => GetValue<GcActionUseType>();
		set => TrySetValue<GcActionUseType>(value);
	}

	public NMSString0x20 ExternalId
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 ExternalLoc
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20A LocTag
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcActionSetAction> Actions
	{
		get => cache.GetOrAddValue(new VirtualList<GcActionSetAction>(address + GetOffset()));
		set => TrySetValue<GcActionSetAction>(value);
	}

	public GcActionSet(long address) : base(address)
	{

	}
}
