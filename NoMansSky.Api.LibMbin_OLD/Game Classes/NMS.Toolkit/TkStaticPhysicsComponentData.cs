using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkStaticPhysicsComponentData : NMSTemplate
{
	public TkPhysicsData Data
	{
		get => GetValue<TkPhysicsData>();
		set => TrySetValue<TkPhysicsData>(value);
	}

	public Boolean AddToWorldOnPrepare
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AddToWorldImmediately
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkVolumeTriggerType TriggerVolumeType
	{
		get => GetValue<TkVolumeTriggerType>();
		set => TrySetValue<TkVolumeTriggerType>(value);
	}

	public Boolean TriggerVolume
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Climbable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NoVehicleCollide
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NoPlayerCollide
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CameraInvisible
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkStaticPhysicsComponentData(long address) : base(address)
	{

	}
}
