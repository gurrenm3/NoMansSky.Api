using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkVoxelGeneratorSettingsElement : NMSTemplate
{
	public TkVoxelGeneratorData Min
	{
		get => GetValue<TkVoxelGeneratorData>();
		set => TrySetValue<TkVoxelGeneratorData>(value);
	}

	public TkVoxelGeneratorData Max
	{
		get => GetValue<TkVoxelGeneratorData>();
		set => TrySetValue<TkVoxelGeneratorData>(value);
	}

	public TkVoxelGeneratorSettingsElement(long address) : base(address)
	{

	}
}
