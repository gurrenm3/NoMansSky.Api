using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationThrusterEffects : NMSTemplate
{
	public VirtualList<GcCustomisationThrusterEffect> JetpackEffects
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationThrusterEffect>(address + GetOffset()));
		set => TrySetValue<GcCustomisationThrusterEffect>(value);
	}

	public VirtualList<GcCustomisationBackpackData> BackpackData
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationBackpackData>(address + GetOffset()));
		set => TrySetValue<GcCustomisationBackpackData>(value);
	}

	public VirtualList<GcCustomisationShipTrails> ShipEffects
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationShipTrails>(address + GetOffset()));
		set => TrySetValue<GcCustomisationShipTrails>(value);
	}

	public VirtualList<GcCustomisationFreighterEngineEffect> FreighterEngineEffects
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationFreighterEngineEffect>(address + GetOffset()));
		set => TrySetValue<GcCustomisationFreighterEngineEffect>(value);
	}

	public GcCustomisationThrusterEffects(long address) : base(address)
	{

	}
}
