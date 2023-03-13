using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCombatEffectsTable : NMSTemplate
{
	public VirtualArray<GcCombatEffectData> EffectsData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCombatEffectData>(address + GetOffset(), 4));
		set => TrySetValue<GcCombatEffectData>(value);
	}

	public GcCombatEffectsTable(long address) : base(address)
	{

	}
}
