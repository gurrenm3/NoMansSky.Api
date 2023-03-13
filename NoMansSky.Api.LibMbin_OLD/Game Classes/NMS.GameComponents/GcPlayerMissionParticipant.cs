using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerMissionParticipant : NMSTemplate
{
	public UInt64 UA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcSeed BuildingSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public Vector3f BuildingLocation
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcPlayerMissionParticipantType ParticipantType
	{
		get => GetValue<GcPlayerMissionParticipantType>();
		set => TrySetValue<GcPlayerMissionParticipantType>(value);
	}

	public GcPlayerMissionParticipant(long address) : base(address)
	{

	}
}
