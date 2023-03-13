using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcParticleAction : NMSTemplate
{
	public NMSString0x10 Effect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20 Joint
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean Exact
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBroadcastLevel FindRange
	{
		get => GetValue<GcBroadcastLevel>();
		set => TrySetValue<GcBroadcastLevel>(value);
	}

	public GcParticleAction(long address) : base(address)
	{

	}
}
