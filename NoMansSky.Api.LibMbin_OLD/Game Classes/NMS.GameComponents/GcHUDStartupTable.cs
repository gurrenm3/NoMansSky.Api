using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHUDStartupTable : NMSTemplate
{
	public Single FadeInFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartHoldTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ButtonFlashRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ButtonFlashAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BackgroundAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<GcHUDStartup> HUDStartup
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHUDStartup>(address + GetOffset(), 13));
		set => TrySetValue<GcHUDStartup>(value);
	}

	public GcHUDStartupTable(long address) : base(address)
	{

	}
}
