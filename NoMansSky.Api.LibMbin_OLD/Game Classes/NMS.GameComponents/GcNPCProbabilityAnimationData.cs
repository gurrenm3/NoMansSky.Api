using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCProbabilityAnimationData : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcNPCProbabilityAnimationData.AnimationIntensityEnum AnimationIntensity
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCProbabilityAnimationData.AnimationIntensityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCProbabilityAnimationData.AnimationIntensityEnum>(value);
	}

	public VirtualList<GcAlienRace> ExcludeRace
	{
		get => cache.GetOrAddValue(new VirtualList<GcAlienRace>(address + GetOffset()));
		set => TrySetValue<GcAlienRace>(value);
	}

	public VirtualList<NMSString0x10> Tags
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcNPCProbabilityAnimationData(long address) : base(address)
	{

	}
}
