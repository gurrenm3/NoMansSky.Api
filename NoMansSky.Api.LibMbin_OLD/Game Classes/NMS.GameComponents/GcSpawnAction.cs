using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpawnAction : NMSTemplate
{
	public NMSString0x10 Event
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcSpawnAction(long address) : base(address)
	{

	}
}
