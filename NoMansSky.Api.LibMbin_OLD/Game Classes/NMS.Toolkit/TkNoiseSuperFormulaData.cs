using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseSuperFormulaData : NMSTemplate
{
	public Single Form_m
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Form_n1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Form_n2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Form_n3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkNoiseSuperFormulaData(long address) : base(address)
	{

	}
}
