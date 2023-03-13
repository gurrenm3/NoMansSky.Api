using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceFreighterEngage : NMSTemplate
{
	public NMSString0x80 MessageGetToSpace
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 MessageEngage
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single EngageDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeAfterWarp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 TimeoutMessage
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 TimeoutOSDMessage
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceFreighterEngage(long address) : base(address)
	{

	}
}
