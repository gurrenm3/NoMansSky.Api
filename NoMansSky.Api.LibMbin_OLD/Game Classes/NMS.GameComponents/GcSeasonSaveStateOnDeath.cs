using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSeasonSaveStateOnDeath : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSeasonSaveStateOnDeath.SeasonSaveStateOnDeathEnum SeasonSaveStateOnDeath
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSeasonSaveStateOnDeath.SeasonSaveStateOnDeathEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSeasonSaveStateOnDeath.SeasonSaveStateOnDeathEnum>(value);
	}

	public GcSeasonSaveStateOnDeath(long address) : base(address)
	{

	}
}
