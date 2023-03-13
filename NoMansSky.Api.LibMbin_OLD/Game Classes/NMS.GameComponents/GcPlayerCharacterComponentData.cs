using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerCharacterComponentData : NMSTemplate
{
	public VirtualList<GcCharacterJetpackEffect> JetpackEffects
	{
		get => cache.GetOrAddValue(new VirtualList<GcCharacterJetpackEffect>(address + GetOffset()));
		set => TrySetValue<GcCharacterJetpackEffect>(value);
	}

	public NMSString0x10 IntialPlayerControlMode
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcPlayerControlModeEntry> PlayerControlModes
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerControlModeEntry>(address + GetOffset()));
		set => TrySetValue<GcPlayerControlModeEntry>(value);
	}

	public GcPlayerCharacterComponentData(long address) : base(address)
	{

	}
}
