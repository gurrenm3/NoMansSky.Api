using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtlasMessage : NMSTemplate
{
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

	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Int32 ColourIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcAtlasMessage(long address) : base(address)
	{

	}
}
