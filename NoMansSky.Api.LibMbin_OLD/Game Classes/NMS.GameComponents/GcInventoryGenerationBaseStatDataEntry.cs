using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryGenerationBaseStatDataEntry : NMSTemplate
{
	public NMSString0x10 BaseStatID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Min
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Max
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinFixedAdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxFixedAdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcInventoryGenerationBaseStatDataEntry(long address) : base(address)
	{

	}
}
