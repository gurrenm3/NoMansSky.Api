using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkEngineSettingsMapping : NMSTemplate
{
	public VirtualArray<Single> ShadowMultiplier
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> ReflectionMultiplier
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> ReflectionProbesMultiplier
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> IKFullBodyIterations
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> CloudsResolutionScale
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Int32> CloudsMaxIterations
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Boolean> NeedsGameRestart
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 49));
		set => TrySetValue<Boolean>(value);
	}

	public TkEngineSettingsMapping(long address) : base(address)
	{

	}
}
