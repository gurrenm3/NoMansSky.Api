using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkVoxelGeneratorSettingsTypes : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkVoxelGeneratorSettingsTypes.TerrainSettingsEnum TerrainSettings
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkVoxelGeneratorSettingsTypes.TerrainSettingsEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkVoxelGeneratorSettingsTypes.TerrainSettingsEnum>(value);
	}

	public TkVoxelGeneratorSettingsTypes(long address) : base(address)
	{

	}
}
