using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkPhysicsComponentData : NMSTemplate
{
	public TkPhysicsData Data
	{
		get => GetValue<TkPhysicsData>();
		set => TrySetValue<TkPhysicsData>(value);
	}

	public NMSTemplate RagdollData
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public TkVolumeTriggerType TriggerVolumeType
	{
		get => GetValue<TkVolumeTriggerType>();
		set => TrySetValue<TkVolumeTriggerType>(value);
	}

	public libMBIN.NMS.Toolkit.TkPhysicsComponentData.SurfacePropertiesEnum SurfaceProperties
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkPhysicsComponentData.SurfacePropertiesEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkPhysicsComponentData.SurfacePropertiesEnum>(value);
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

	public Boolean Floor
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IgnoreModelOwner
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

	public Boolean InvisibleForInteraction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowTeleporter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BlockTeleporter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableGravity
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SpinOnCreate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseBasePartOptimisation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsTransporter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkPhysicsComponentData(long address) : base(address)
	{

	}
}
