using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementPerkData : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A Name
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Description
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean IsNegative
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsStarter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsProc
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsJob
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcSettlementStatChange> StatChanges
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementStatChange>(address + GetOffset()));
		set => TrySetValue<GcSettlementStatChange>(value);
	}

	public GcSettlementPerkData(long address) : base(address)
	{

	}
}
