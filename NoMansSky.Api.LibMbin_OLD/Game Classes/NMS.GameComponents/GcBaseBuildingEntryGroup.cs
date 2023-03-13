using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingEntryGroup : NMSTemplate
{
	public NMSString0x10 Group
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SubGroupName
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 SubGroup
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBaseBuildingEntryGroup(long address) : base(address)
	{

	}
}
