using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcObjectPlacementComponentData : NMSTemplate
{
	public NMSString0x20 GroupNodeName
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectPlacementComponentData.ActivationTypeEnum ActivationType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectPlacementComponentData.ActivationTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectPlacementComponentData.ActivationTypeEnum>(value);
	}

	public Single FractionOfNodesActive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxNodesActivated
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxGroupsActivated
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UseRaycast
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseNodeParent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcObjectPlacementComponentData(long address) : base(address)
	{

	}
}
