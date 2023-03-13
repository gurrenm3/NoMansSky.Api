using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkVoxelGeneratorSettingsArray : NMSTemplate
{
	public VirtualArray<TkVoxelGeneratorSettingsElement> TerrainSettings
	{
		get => cache.GetOrAddValue(new VirtualArray<TkVoxelGeneratorSettingsElement>(address + GetOffset(), 21));
		set => TrySetValue<TkVoxelGeneratorSettingsElement>(value);
	}

	public TkVoxelGeneratorSettingsArray(long address) : base(address)
	{

	}
}
