using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMechAudioEvent : NMSTemplate
{
	public GcAudioWwiseEvents DefaultEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public VirtualList<GcMechPartAudioEventOverride> MeshPartOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcMechPartAudioEventOverride>(address + GetOffset()));
		set => TrySetValue<GcMechPartAudioEventOverride>(value);
	}

	public GcMechAudioEvent(long address) : base(address)
	{

	}
}
