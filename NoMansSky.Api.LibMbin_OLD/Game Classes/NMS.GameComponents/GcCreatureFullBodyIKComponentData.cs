using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureFullBodyIKComponentData : NMSTemplate
{
	public VirtualList<GcCreatureIkData> JointData
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureIkData>(address + GetOffset()));
		set => TrySetValue<GcCreatureIkData>(value);
	}

	public VirtualList<GcIkPistonData> PistonData
	{
		get => cache.GetOrAddValue(new VirtualList<GcIkPistonData>(address + GetOffset()));
		set => TrySetValue<GcIkPistonData>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureFullBodyIKComponentData.HeadUpAxisEnum HeadUpAxis
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureFullBodyIKComponentData.HeadUpAxisEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureFullBodyIKComponentData.HeadUpAxisEnum>(value);
	}

	public Single MaxHeadPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeadRoll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeadYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BodyMassWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Omega
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OmegaDropOff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MovementDamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseFootGlue
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FootPlantSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseFootAngle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FootAngleSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxFootAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UsePistons
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Mech
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCreatureFullBodyIKComponentData(long address) : base(address)
	{

	}
}
