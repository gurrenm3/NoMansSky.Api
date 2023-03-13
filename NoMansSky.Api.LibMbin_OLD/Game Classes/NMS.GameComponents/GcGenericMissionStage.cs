using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGenericMissionStage : NMSTemplate
{
	public VirtualList<GcGenericMissionVersionProgress> Versions
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericMissionVersionProgress>(address + GetOffset()));
		set => TrySetValue<GcGenericMissionVersionProgress>(value);
	}

	public NMSTemplate Stage
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcGenericMissionStage(long address) : base(address)
	{

	}
}
