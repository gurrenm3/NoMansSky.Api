using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraSpawnSetupData : NMSTemplate
{
	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean InFrontOfShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single YawProportion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizontalProportion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraSpawnSetupData(long address) : base(address)
	{

	}
}
