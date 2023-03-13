using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMessageUpdateFrigateSpeed : NMSTemplate
{
	public Single StartSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMessageUpdateFrigateSpeed(long address) : base(address)
	{

	}
}
