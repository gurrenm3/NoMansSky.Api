using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTerrainEdit : NMSTemplate
{
	public Byte Data
	{
		get => GetValue<Byte>();
		set => TrySetValue<Byte>(value);
	}

	public Int32 Position
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcTerrainEdit(long address) : base(address)
	{

	}
}
