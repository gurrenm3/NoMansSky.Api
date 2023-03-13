using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAudioComponentData : NMSTemplate
{
	public NMSString0x80 Ambient
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x10 AmbientState
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 Shutdown
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 MaxDistance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<TkAudioAnimTrigger> AnimTriggers
	{
		get => cache.GetOrAddValue(new VirtualList<TkAudioAnimTrigger>(address + GetOffset()));
		set => TrySetValue<TkAudioAnimTrigger>(value);
	}

	public TkAudioComponentData(long address) : base(address)
	{

	}
}
