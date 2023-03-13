using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelCoverComponentData : NMSTemplate
{
	public Single HealthPercLostPerSecMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HealthPercLostPerSecMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 SpawnEffectId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DestroyEffectId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20 EffectLocator
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualArray<NMSString0x10> CoverStateAnims
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcSentinelCoverComponentData(long address) : base(address)
	{

	}
}
