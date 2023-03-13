using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimPoseData : NMSTemplate
{
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

	public Int32 FrameEnd
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkAnimPoseData(long address) : base(address)
	{

	}
}
