using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSolarSystemEventWarpPlayer : NMSTemplate
{
	public GcSolarSystemLocatorChoice Locator
	{
		get => GetValue<GcSolarSystemLocatorChoice>();
		set => TrySetValue<GcSolarSystemLocatorChoice>(value);
	}

	public Single Time
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSolarSystemEventWarpPlayer(long address) : base(address)
	{

	}
}
