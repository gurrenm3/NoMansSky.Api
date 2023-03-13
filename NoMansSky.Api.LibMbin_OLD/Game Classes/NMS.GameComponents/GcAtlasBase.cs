using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtlasBase : NMSTemplate
{
	public NMSString0x200 OpaqueData
	{
		get => GetValue<NMSString0x200>();
		set => TrySetValue<NMSString0x200>(value);
	}

	public GcUniverseAddressData UniverseAddress
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public NMSString0x80 CustomName
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcAtlasBase(long address) : base(address)
	{

	}
}
