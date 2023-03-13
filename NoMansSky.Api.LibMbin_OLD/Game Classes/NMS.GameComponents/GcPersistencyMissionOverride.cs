using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPersistencyMissionOverride : NMSTemplate
{
	public NMSString0x10 Mission
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcInteractionBufferType Buffer
	{
		get => GetValue<GcInteractionBufferType>();
		set => TrySetValue<GcInteractionBufferType>(value);
	}

	public GcPersistencyMissionOverride(long address) : base(address)
	{

	}
}
