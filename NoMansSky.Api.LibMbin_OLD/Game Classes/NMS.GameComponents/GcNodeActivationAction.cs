using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNodeActivationAction : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNodeActivationAction.NodeActiveStateEnum NodeActiveState
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNodeActivationAction.NodeActiveStateEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNodeActivationAction.NodeActiveStateEnum>(value);
	}

	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 SceneToAdd
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean IncludePhysics
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IncludeChildPhysics
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NotifyNPC
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseMasterModel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseLocalNode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RestartEmitters
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AffectModels
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcNodeActivationAction(long address) : base(address)
	{

	}
}
