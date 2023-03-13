using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourLookData : NMSTemplate
{
	public NMSString0x10 LookTargetKey
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean LookWhenBeyondMaxAngle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkBlackboardDefaultValueBool FocusOnTarget
	{
		get => GetValue<TkBlackboardDefaultValueBool>();
		set => TrySetValue<TkBlackboardDefaultValueBool>(value);
	}

	public TkBlackboardDefaultValueBool RelaxedLook
	{
		get => GetValue<TkBlackboardDefaultValueBool>();
		set => TrySetValue<TkBlackboardDefaultValueBool>(value);
	}

	public TkBlackboardDefaultValueBool CanLook
	{
		get => GetValue<TkBlackboardDefaultValueBool>();
		set => TrySetValue<TkBlackboardDefaultValueBool>(value);
	}

	public GcBehaviourLookData(long address) : base(address)
	{

	}
}
