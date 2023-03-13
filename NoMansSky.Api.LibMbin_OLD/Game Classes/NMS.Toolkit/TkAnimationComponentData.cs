using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimationComponentData : NMSTemplate
{
	public TkAnimationData Idle
	{
		get => GetValue<TkAnimationData>();
		set => TrySetValue<TkAnimationData>(value);
	}

	public VirtualList<TkAnimationData> Anims
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimationData>(address + GetOffset()));
		set => TrySetValue<TkAnimationData>(value);
	}

	public VirtualList<TkAnimBlendTree> Trees
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimBlendTree>(address + GetOffset()));
		set => TrySetValue<TkAnimBlendTree>(value);
	}

	public Boolean NetSyncAnimations
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<TkAnimJointLODData> JointLODOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimJointLODData>(address + GetOffset()));
		set => TrySetValue<TkAnimJointLODData>(value);
	}

	public TkAnimationComponentData(long address) : base(address)
	{

	}
}
