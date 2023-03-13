using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerCharacterIKOverrideData : NMSTemplate
{
	public Boolean Enabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Strength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f RotStrengths
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcPlayerCharacterIKOverrideData(long address) : base(address)
	{

	}
}
