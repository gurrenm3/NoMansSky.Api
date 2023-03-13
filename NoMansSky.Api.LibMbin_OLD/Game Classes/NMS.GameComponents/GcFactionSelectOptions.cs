using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFactionSelectOptions : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFactionSelectOptions.FactionOptionEnum FactionOption
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFactionSelectOptions.FactionOptionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFactionSelectOptions.FactionOptionEnum>(value);
	}

	public GcMissionFaction Faction
	{
		get => GetValue<GcMissionFaction>();
		set => TrySetValue<GcMissionFaction>(value);
	}

	public GcFactionSelectOptions(long address) : base(address)
	{

	}
}
