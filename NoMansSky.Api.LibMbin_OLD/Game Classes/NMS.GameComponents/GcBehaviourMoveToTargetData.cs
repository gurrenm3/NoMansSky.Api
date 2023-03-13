using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourMoveToTargetData : NMSTemplate
{
	public NMSString0x10 TargetKey
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkBlackboardDefaultValueFloat ArriveDist
	{
		get => GetValue<TkBlackboardDefaultValueFloat>();
		set => TrySetValue<TkBlackboardDefaultValueFloat>(value);
	}

	public libMBIN.NMS.GameComponents.GcBehaviourMoveToTargetData.BehaviourMoveSpeedEnum BehaviourMoveSpeed
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBehaviourMoveToTargetData.BehaviourMoveSpeedEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBehaviourMoveToTargetData.BehaviourMoveSpeedEnum>(value);
	}

	public Single DynamicMoveSlowdownDistMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
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

	public GcBehaviourMoveToTargetData(long address) : base(address)
	{

	}
}
