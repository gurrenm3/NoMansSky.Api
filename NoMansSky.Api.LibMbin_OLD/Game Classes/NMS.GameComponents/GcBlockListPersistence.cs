using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBlockListPersistence : NMSTemplate
{
	public VirtualArray<GcBlockedUser> BlockedUserArray
	{
		get => cache.GetOrAddValue(new VirtualArray<GcBlockedUser>(address + GetOffset(), 50));
		set => TrySetValue<GcBlockedUser>(value);
	}

	public Int32 NextSlot
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ListSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<GcBlockedMessage> BlockedMessageArray
	{
		get => cache.GetOrAddValue(new VirtualArray<GcBlockedMessage>(address + GetOffset(), 50));
		set => TrySetValue<GcBlockedMessage>(value);
	}

	public Int32 MessageNextSlot
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MessageListSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBlockListPersistence(long address) : base(address)
	{

	}
}
