using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCAnimationSetData : NMSTemplate
{
	public VirtualList<GcNPCProbabilityAnimationData> IdleAnimations
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCProbabilityAnimationData>(address + GetOffset()));
		set => TrySetValue<GcNPCProbabilityAnimationData>(value);
	}

	public VirtualList<GcNPCProbabilityAnimationData> IdleFlavourAnimations
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCProbabilityAnimationData>(address + GetOffset()));
		set => TrySetValue<GcNPCProbabilityAnimationData>(value);
	}

	public VirtualList<GcNPCProbabilityAnimationData> ChatterAnimations
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCProbabilityAnimationData>(address + GetOffset()));
		set => TrySetValue<GcNPCProbabilityAnimationData>(value);
	}

	public VirtualList<GcNPCProbabilityAnimationData> ListenAnimations
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCProbabilityAnimationData>(address + GetOffset()));
		set => TrySetValue<GcNPCProbabilityAnimationData>(value);
	}

	public VirtualList<GcNPCProbabilityAnimationData> GreetAnimations
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCProbabilityAnimationData>(address + GetOffset()));
		set => TrySetValue<GcNPCProbabilityAnimationData>(value);
	}

	public VirtualArray<GcNPCAnimationList> MoodAnims
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNPCAnimationList>(address + GetOffset(), 9));
		set => TrySetValue<GcNPCAnimationList>(value);
	}

	public VirtualArray<NMSString0x10> MoodLoops
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 9));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcNPCAnimationSetData(long address) : base(address)
	{

	}
}
