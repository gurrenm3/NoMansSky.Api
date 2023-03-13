using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourMaintainRangeFromTargetData : NMSTemplate
{
	public NMSString0x10 TargetKey
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkBlackboardDefaultValueFloat MinDist
	{
		get => GetValue<TkBlackboardDefaultValueFloat>();
		set => TrySetValue<TkBlackboardDefaultValueFloat>(value);
	}

	public TkBlackboardDefaultValueFloat MaxDist
	{
		get => GetValue<TkBlackboardDefaultValueFloat>();
		set => TrySetValue<TkBlackboardDefaultValueFloat>(value);
	}

	public Boolean _2D
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SucceedWhenInRange
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SpeedModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AvoidCreaturesStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBehaviourMaintainRangeFromTargetData(long address) : base(address)
	{

	}
}
