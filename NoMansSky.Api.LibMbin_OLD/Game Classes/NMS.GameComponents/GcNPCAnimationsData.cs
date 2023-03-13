using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCAnimationsData : NMSTemplate
{
	public GcNPCAnimationSetData StandingAnimatons
	{
		get => GetValue<GcNPCAnimationSetData>();
		set => TrySetValue<GcNPCAnimationSetData>(value);
	}

	public GcNPCAnimationSetData StandingIPadAnimatons
	{
		get => GetValue<GcNPCAnimationSetData>();
		set => TrySetValue<GcNPCAnimationSetData>(value);
	}

	public GcNPCAnimationSetData SittingAnimatons
	{
		get => GetValue<GcNPCAnimationSetData>();
		set => TrySetValue<GcNPCAnimationSetData>(value);
	}

	public GcNPCAnimationSetData SittingIPadAnimatons
	{
		get => GetValue<GcNPCAnimationSetData>();
		set => TrySetValue<GcNPCAnimationSetData>(value);
	}

	public GcNPCAnimationsData(long address) : base(address)
	{

	}
}
