using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSolarSystemLocator : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcSolarSystemLocatorTypes Type
	{
		get => GetValue<GcSolarSystemLocatorTypes>();
		set => TrySetValue<GcSolarSystemLocatorTypes>(value);
	}

	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Direction
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSolarSystemLocator(long address) : base(address)
	{

	}
}
