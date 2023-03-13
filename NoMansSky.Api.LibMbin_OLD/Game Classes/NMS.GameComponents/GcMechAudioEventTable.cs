using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMechAudioEventTable : NMSTemplate
{
	public GcMechAudioEvent MechEnter
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent MechExit
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent StepWalk
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent StepRun
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent TitanFallLanding
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent JumpLanding
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent JumpLandingSkid
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent TitanFallPoseIntro
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent JetpackTrigger
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent JetpackRetrigger
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent JetpackLP
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEvent JetpackLPEnd
	{
		get => GetValue<GcMechAudioEvent>();
		set => TrySetValue<GcMechAudioEvent>(value);
	}

	public GcMechAudioEventTable(long address) : base(address)
	{

	}
}
