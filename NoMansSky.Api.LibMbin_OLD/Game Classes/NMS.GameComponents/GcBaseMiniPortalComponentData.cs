using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseMiniPortalComponentData : NMSTemplate
{
	public Boolean AllowVehicles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowSpawnedObjects
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FlipFacingDirection
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SnapFacingDirection
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SnapFacingAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DoPlayerEffects
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TeleportCamera
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 PowerCost
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 GroupID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DestinationGroupID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcBaseMiniPortalComponentData.DestinationSortTypeEnum DestinationSortType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseMiniPortalComponentData.DestinationSortTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseMiniPortalComponentData.DestinationSortTypeEnum>(value);
	}

	public GcBaseMiniPortalComponentData(long address) : base(address)
	{

	}
}
