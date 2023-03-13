using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCombatEffectsComponentData : NMSTemplate
{
	public VirtualArray<GcCombatEffectsProperties> EffectsProperties
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCombatEffectsProperties>(address + GetOffset(), 4));
		set => TrySetValue<GcCombatEffectsProperties>(value);
	}

	public GcCombatEffectsComponentData(long address) : base(address)
	{

	}
}
