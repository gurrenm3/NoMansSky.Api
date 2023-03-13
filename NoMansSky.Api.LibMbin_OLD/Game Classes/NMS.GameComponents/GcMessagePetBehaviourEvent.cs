using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMessagePetBehaviourEvent : NMSTemplate
{
	public NMSString0x10 BehaviourEvent
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A UserData
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcPetBehaviours ForceBehaviour
	{
		get => GetValue<GcPetBehaviours>();
		set => TrySetValue<GcPetBehaviours>(value);
	}

	public GcAlienMood Mood
	{
		get => GetValue<GcAlienMood>();
		set => TrySetValue<GcAlienMood>(value);
	}

	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Direction
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcNodeID SourceNode
	{
		get => GetValue<GcNodeID>();
		set => TrySetValue<GcNodeID>(value);
	}

	public GcMessagePetBehaviourEvent(long address) : base(address)
	{

	}
}
