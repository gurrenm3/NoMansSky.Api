using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimPoseExampleElement : NMSTemplate
{
	public NMSString0x10 Anim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Value
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkAnimPoseExampleElement(long address) : base(address)
	{

	}
}
