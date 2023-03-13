using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkCameraWanderData : NMSTemplate
{
	public Boolean CamWander
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CamWanderPhase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CamWanderAmplitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCameraWanderData(long address) : base(address)
	{

	}
}
