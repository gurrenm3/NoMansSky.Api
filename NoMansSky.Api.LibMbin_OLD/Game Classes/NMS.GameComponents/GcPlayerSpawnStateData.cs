using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerSpawnStateData : NMSTemplate
{
	public Vector4f PlayerPositionInSystem
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f PlayerTransformAt
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f PlayerDeathRespawnPositionInSystem
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f PlayerDeathRespawnTransformAt
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f ShipPositionInSystem
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f ShipTransformAt
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlayerSpawnStateData.LastKnownPlayerStateEnum LastKnownPlayerState
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerSpawnStateData.LastKnownPlayerStateEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerSpawnStateData.LastKnownPlayerStateEnum>(value);
	}

	public Vector4f FreighterPositionInSystem
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f FreighterTransformAt
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f FreighterTransformUp
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f AbandonedFreighterPositionInSystem
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f AbandonedFreighterTransformAt
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f AbandonedFreighterTransformUp
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public GcPlayerSpawnStateData(long address) : base(address)
	{

	}
}
