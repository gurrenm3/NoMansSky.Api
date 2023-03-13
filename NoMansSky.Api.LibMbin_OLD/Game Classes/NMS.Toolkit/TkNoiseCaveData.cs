using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseCaveData : NMSTemplate
{
	public TkNoiseFeatureData Mouth
	{
		get => GetValue<TkNoiseFeatureData>();
		set => TrySetValue<TkNoiseFeatureData>(value);
	}

	public TkNoiseFeatureData Tunnel
	{
		get => GetValue<TkNoiseFeatureData>();
		set => TrySetValue<TkNoiseFeatureData>(value);
	}

	public TkNoiseCaveData(long address) : base(address)
	{

	}
}
