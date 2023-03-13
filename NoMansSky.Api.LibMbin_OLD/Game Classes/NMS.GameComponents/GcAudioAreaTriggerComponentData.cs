using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAudioAreaTriggerComponentData : NMSTemplate
{
	public GcAudioWwiseEvents EventEnter
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents EventExit
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public Single EnterDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAudioAreaTriggerComponentData(long address) : base(address)
	{

	}
}
