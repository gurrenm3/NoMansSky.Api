using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingBlueprint : NMSTemplate
{
	public NMSString0x10 ProductID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 GroupId
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBuildingBlueprint(long address) : base(address)
	{

	}
}
