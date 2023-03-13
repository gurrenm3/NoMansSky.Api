using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcByteBeatWave : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcByteBeatWave.ByteBeatWaveEnum ByteBeatWave
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcByteBeatWave.ByteBeatWaveEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcByteBeatWave.ByteBeatWaveEnum>(value);
	}

	public GcByteBeatWave(long address) : base(address)
	{

	}
}
