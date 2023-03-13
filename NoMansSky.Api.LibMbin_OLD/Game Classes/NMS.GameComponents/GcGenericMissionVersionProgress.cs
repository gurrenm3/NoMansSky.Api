using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGenericMissionVersionProgress : NMSTemplate
{
	public Int32 Version
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Progress
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcGenericMissionVersionProgress(long address) : base(address)
	{

	}
}
