using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGeneratedBasePruningRule : NMSTemplate
{
	public NMSString0x10 RuleId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 NodeName
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 MaxPerRoom
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxPerDungeon
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<NMSString0x10> RoomFilters
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcGeneratedBasePruningRule(long address) : base(address)
	{

	}
}
