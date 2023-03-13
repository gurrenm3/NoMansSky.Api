using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcQuestItemPlacementRule : NMSTemplate
{
	public NMSString0x10 QuestItemID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 MinRoomIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxRoomIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 MustBeBeforeQuestItem
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 MustBeAfterQuestItem
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> ValidRoomIDs
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcQuestItemPlacementRule(long address) : base(address)
	{

	}
}
