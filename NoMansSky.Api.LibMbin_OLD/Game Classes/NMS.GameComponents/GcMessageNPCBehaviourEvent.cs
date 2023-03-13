using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMessageNPCBehaviourEvent : NMSTemplate
{
	public NMSString0x10 BehaviourEvent
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 UserData
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcNPCTriggerTypes InteractionTrigger
	{
		get => GetValue<GcNPCTriggerTypes>();
		set => TrySetValue<GcNPCTriggerTypes>(value);
	}

	public Int32 InteractionSubType
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcNodeID SourceNode
	{
		get => GetValue<GcNodeID>();
		set => TrySetValue<GcNodeID>(value);
	}

	public GcMessageNPCBehaviourEvent(long address) : base(address)
	{

	}
}
