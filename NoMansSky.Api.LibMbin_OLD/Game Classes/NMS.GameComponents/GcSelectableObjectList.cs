using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSelectableObjectList : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public VirtualList<GcSelectableObjectData> Options
	{
		get => cache.GetOrAddValue(new VirtualList<GcSelectableObjectData>(address + GetOffset()));
		set => TrySetValue<GcSelectableObjectData>(value);
	}

	public GcSelectableObjectList(long address) : base(address)
	{

	}
}
