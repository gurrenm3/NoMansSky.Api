using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerNearbyEvent : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlayerNearbyEvent.RequirePlayerActionEnum RequirePlayerAction
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerNearbyEvent.RequirePlayerActionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerNearbyEvent.RequirePlayerActionEnum>(value);
	}

	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Angle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AnglePlayerRelative
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AngleOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AngleReflected
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AngleMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlayerNearbyEvent.DistanceCheckTypeEnum DistanceCheckType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerNearbyEvent.DistanceCheckTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerNearbyEvent.DistanceCheckTypeEnum>(value);
	}

	public Boolean Inverse
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OnlyForLocalPlayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IncludeAllPhysics
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IncludeMobileNPCs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TeleporterCountsAsPlayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPlayerNearbyEvent(long address) : base(address)
	{

	}
}
