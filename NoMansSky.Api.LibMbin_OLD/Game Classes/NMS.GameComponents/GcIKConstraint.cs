using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcIKConstraint : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x100 JointName
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public GcCreatureIkType Type
	{
		get => GetValue<GcCreatureIkType>();
		set => TrySetValue<GcCreatureIkType>(value);
	}

	public GcPlayerCharacterIKOverrideData DefaultState
	{
		get => GetValue<GcPlayerCharacterIKOverrideData>();
		set => TrySetValue<GcPlayerCharacterIKOverrideData>(value);
	}

	public VirtualList<GcPlayerCharacterIKStateData> States
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerCharacterIKStateData>(address + GetOffset()));
		set => TrySetValue<GcPlayerCharacterIKStateData>(value);
	}

	public GcIKConstraint(long address) : base(address)
	{

	}
}
