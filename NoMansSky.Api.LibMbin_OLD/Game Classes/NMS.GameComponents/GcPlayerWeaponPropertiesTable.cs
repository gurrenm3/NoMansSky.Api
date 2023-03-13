using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerWeaponPropertiesTable : NMSTemplate
{
	public GcCamouflageData CamouflageData
	{
		get => GetValue<GcCamouflageData>();
		set => TrySetValue<GcCamouflageData>(value);
	}

	public VirtualArray<GcPlayerWeaponPropertiesData> PropertiesData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlayerWeaponPropertiesData>(address + GetOffset(), 19));
		set => TrySetValue<GcPlayerWeaponPropertiesData>(value);
	}

	public GcPlayerWeaponPropertiesTable(long address) : base(address)
	{

	}
}
