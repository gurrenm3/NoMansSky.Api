using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerControlInput : NMSTemplate
{
	public Boolean InterceptAllInputs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcInputActions> InterceptInputWhitelist
	{
		get => cache.GetOrAddValue(new VirtualList<GcInputActions>(address + GetOffset()));
		set => TrySetValue<GcInputActions>(value);
	}

	public VirtualList<GcInputActions> InterceptInputBlackList
	{
		get => cache.GetOrAddValue(new VirtualList<GcInputActions>(address + GetOffset()));
		set => TrySetValue<GcInputActions>(value);
	}

	public VirtualList<NMSTemplate> Inputs
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcPlayerControlInput(long address) : base(address)
	{

	}
}
