using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseVoxelTypeEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkNoiseVoxelTypeEnum.NoiseVoxelTypeEnum NoiseVoxelType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNoiseVoxelTypeEnum.NoiseVoxelTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNoiseVoxelTypeEnum.NoiseVoxelTypeEnum>(value);
	}

	public TkNoiseVoxelTypeEnum(long address) : base(address)
	{

	}
}
