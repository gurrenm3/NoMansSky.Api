using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerCommunicatorMessageWeighted : NMSTemplate
{
	public GcPlayerCommunicatorMessage Message
	{
		get => GetValue<GcPlayerCommunicatorMessage>();
		set => TrySetValue<GcPlayerCommunicatorMessage>(value);
	}

	public Int32 Weight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPlayerCommunicatorMessageWeighted(long address) : base(address)
	{

	}
}
