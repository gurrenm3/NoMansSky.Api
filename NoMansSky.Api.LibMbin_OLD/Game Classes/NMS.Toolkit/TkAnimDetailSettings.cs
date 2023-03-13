using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimDetailSettings : NMSTemplate
{
	public Single MaxVisibleAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<TkAnimDetailSettingsData> AnimDistanceSettings
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimDetailSettingsData>(address + GetOffset()));
		set => TrySetValue<TkAnimDetailSettingsData>(value);
	}

	public VirtualArray<Single> AnimLODDistances
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public TkAnimDetailSettings(long address) : base(address)
	{

	}
}
