using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAudioAnimTrigger : NMSTemplate
{
	public NMSString0x80 Sound
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x10 Anim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 FrameStart
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkAudioAnimTrigger(long address) : base(address)
	{

	}
}
