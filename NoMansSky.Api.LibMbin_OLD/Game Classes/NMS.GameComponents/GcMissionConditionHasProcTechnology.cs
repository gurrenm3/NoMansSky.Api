using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasProcTechnology : NMSTemplate
{
	public NMSString0x20A ProcTechGroupID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Int32 Count
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMissionConditionHasProcTechnology(long address) : base(address)
	{

	}
}
