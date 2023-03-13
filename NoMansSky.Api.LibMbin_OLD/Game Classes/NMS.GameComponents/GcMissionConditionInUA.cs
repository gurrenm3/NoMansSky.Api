using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionInUA : NMSTemplate
{
	public NMSString0x100 UA
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public GcMissionConditionInUA(long address) : base(address)
	{

	}
}
