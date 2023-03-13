using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRealityCommonFactions : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRealityCommonFactions.AIFactionEnum AIFaction
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRealityCommonFactions.AIFactionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRealityCommonFactions.AIFactionEnum>(value);
	}

	public GcRealityCommonFactions(long address) : base(address)
	{

	}
}
