using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionDifficultyKeyframe : NMSTemplate
{
	public Int32 EventNumber
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single Difficulty
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcExpeditionDifficultyKeyframe(long address) : base(address)
	{

	}
}
