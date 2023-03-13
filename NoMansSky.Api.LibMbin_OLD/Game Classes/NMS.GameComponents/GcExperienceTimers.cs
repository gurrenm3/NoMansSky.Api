using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExperienceTimers : NMSTemplate
{
	public Int32 HighChance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LowChance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector2f High
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f Normal
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f Low
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcExperienceTimers(long address) : base(address)
	{

	}
}
