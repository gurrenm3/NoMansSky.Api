using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPartAudioLocationEntry : NMSTemplate
{
	public NMSString0x10 PartId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcBasePartAudioLocation AudioLocation
	{
		get => GetValue<GcBasePartAudioLocation>();
		set => TrySetValue<GcBasePartAudioLocation>(value);
	}

	public GcBaseBuildingPartAudioLocationEntry(long address) : base(address)
	{

	}
}
