using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipDialogue : NMSTemplate
{
	public VirtualArray<GcPlayerCommunicatorMessageWeighted> DialogueTree
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlayerCommunicatorMessageWeighted>(address + GetOffset(), 7));
		set => TrySetValue<GcPlayerCommunicatorMessageWeighted>(value);
	}

	public GcShipDialogue(long address) : base(address)
	{

	}
}
