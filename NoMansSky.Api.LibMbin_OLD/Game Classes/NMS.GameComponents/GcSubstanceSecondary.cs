using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSubstanceSecondary : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Chance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AmountMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AmountMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSubstanceSecondary(long address) : base(address)
	{

	}
}
