using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourFaceTargetData : NMSTemplate
{
	public NMSString0x10 TargetKey
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single ArriveAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBehaviourFaceTargetData(long address) : base(address)
	{

	}
}
