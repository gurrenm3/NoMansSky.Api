using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMechPartAudioEventOverride : NMSTemplate
{
	public GcMechMeshPart MeshPart
	{
		get => GetValue<GcMechMeshPart>();
		set => TrySetValue<GcMechMeshPart>(value);
	}

	public GcMechMeshType MeshType
	{
		get => GetValue<GcMechMeshType>();
		set => TrySetValue<GcMechMeshType>(value);
	}

	public GcAudioWwiseEvents OverrideEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcMechPartAudioEventOverride(long address) : base(address)
	{

	}
}
