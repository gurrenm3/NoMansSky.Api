using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkParticleBurstData : NMSTemplate
{
	public TkEmitterFloatProperty BurstAmount
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public TkEmitterFloatProperty BurstInterval
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public Int32 LoopCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkParticleBurstData(long address) : base(address)
	{

	}
}
