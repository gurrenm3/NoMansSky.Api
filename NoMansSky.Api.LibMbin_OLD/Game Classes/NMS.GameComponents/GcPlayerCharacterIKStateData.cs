using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerCharacterIKStateData : NMSTemplate
{
	public GcPlayerCharacterStateType State
	{
		get => GetValue<GcPlayerCharacterStateType>();
		set => TrySetValue<GcPlayerCharacterStateType>(value);
	}

	public GcPlayerCharacterIKOverrideData Data
	{
		get => GetValue<GcPlayerCharacterIKOverrideData>();
		set => TrySetValue<GcPlayerCharacterIKOverrideData>(value);
	}

	public VirtualList<GcPlayerCharacterAnimationOverrideData> AnimOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerCharacterAnimationOverrideData>(address + GetOffset()));
		set => TrySetValue<GcPlayerCharacterAnimationOverrideData>(value);
	}

	public GcPlayerCharacterIKStateData(long address) : base(address)
	{

	}
}
