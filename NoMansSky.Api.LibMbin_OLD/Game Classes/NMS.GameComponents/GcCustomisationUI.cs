using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationUI : NMSTemplate
{
	public GcCustomisationCameraData RacesCameraData
	{
		get => GetValue<GcCustomisationCameraData>();
		set => TrySetValue<GcCustomisationCameraData>(value);
	}

	public VirtualList<GcCustomisationRace> Races
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationRace>(address + GetOffset()));
		set => TrySetValue<GcCustomisationRace>(value);
	}

	public GcCustomisationGroups Common
	{
		get => GetValue<GcCustomisationGroups>();
		set => TrySetValue<GcCustomisationGroups>(value);
	}

	public GcCustomisationUI(long address) : base(address)
	{

	}
}
