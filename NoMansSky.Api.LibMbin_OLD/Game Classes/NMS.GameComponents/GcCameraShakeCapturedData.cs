using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraShakeCapturedData : NMSTemplate
{
	public Boolean Active
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ShakeStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShakeFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VibrateStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VibrateFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraShakeCapturedData(long address) : base(address)
	{

	}
}
