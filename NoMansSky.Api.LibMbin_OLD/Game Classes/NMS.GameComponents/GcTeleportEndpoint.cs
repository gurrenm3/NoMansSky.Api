using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTeleportEndpoint : NMSTemplate
{
	public GcUniverseAddressData UniverseAddress
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Facing
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public libMBIN.NMS.GameComponents.GcTeleportEndpoint.TeleporterTypeEnum TeleporterType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTeleportEndpoint.TeleporterTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTeleportEndpoint.TeleporterTypeEnum>(value);
	}

	public NMSString0x40 Name
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Boolean CalcWarpOffset
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsFeatured
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcTeleportEndpoint(long address) : base(address)
	{

	}
}
