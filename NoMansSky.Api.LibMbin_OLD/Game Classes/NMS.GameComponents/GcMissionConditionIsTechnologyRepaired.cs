using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionIsTechnologyRepaired : NMSTemplate
{
	public NMSString0x10 Technology
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 RepairedComponents
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMissionConditionIsTechnologyRepaired(long address) : base(address)
	{

	}
}
