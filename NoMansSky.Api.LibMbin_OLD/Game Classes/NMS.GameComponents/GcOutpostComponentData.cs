using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcOutpostComponentData : NMSTemplate
{
	public Boolean Anomaly
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Frigate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceStation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NexusExterior
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NexusInterior
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AIDestination
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HasDoors
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HasOwnGravity
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 Door
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean CheckLandingAreaClear
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CircleRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ApproachRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ApproachAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ApproachSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerAutoLandRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RotateToDock
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TakeOffHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffFwdDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffAlignTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffExtraAIHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PostTakeOffExtraPlayerHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PostTakeOffExtraPlayerSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffProgressForExtraHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcOutpostLSystemPair> LSystems
	{
		get => cache.GetOrAddValue(new VirtualList<GcOutpostLSystemPair>(address + GetOffset()));
		set => TrySetValue<GcOutpostLSystemPair>(value);
	}

	public GcOutpostComponentData(long address) : base(address)
	{

	}
}
