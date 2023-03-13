using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtlasSendSubmitContribution : NMSTemplate
{
	public Int32 MissionIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Contribution
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcAtlasSendSubmitContribution(long address) : base(address)
	{

	}
}
