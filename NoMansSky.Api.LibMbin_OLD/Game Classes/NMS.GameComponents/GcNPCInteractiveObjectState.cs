using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCInteractiveObjectState : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean FaceSpawnDir
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FaceNodeDir
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FaceInvNodeDir
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LookAtModel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x40 LookAtNode
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Boolean FaceLookAt
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MaintainLookAt
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PlayIdles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CanConverse
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcNPCPropType Prop
	{
		get => GetValue<GcNPCPropType>();
		set => TrySetValue<GcNPCPropType>(value);
	}

	public GcNPCSeatedPosture SeatedPosture
	{
		get => GetValue<GcNPCSeatedPosture>();
		set => TrySetValue<GcNPCSeatedPosture>(value);
	}

	public Single BlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EarlyOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcNPCProbabilityAnimationData> Animations
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCProbabilityAnimationData>(address + GetOffset()));
		set => TrySetValue<GcNPCProbabilityAnimationData>(value);
	}

	public Single SpineAdjustAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MinAnims
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxAnims
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcNPCInteractiveObjectStateTransition> Transitions
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCInteractiveObjectStateTransition>(address + GetOffset()));
		set => TrySetValue<GcNPCInteractiveObjectStateTransition>(value);
	}

	public GcNPCInteractiveObjectState(long address) : base(address)
	{

	}
}
