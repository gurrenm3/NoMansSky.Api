using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureIkData : NMSTemplate
{
	public GcCreatureIkType Type
	{
		get => GetValue<GcCreatureIkType>();
		set => TrySetValue<GcCreatureIkType>(value);
	}

	public NMSString0x100 JointName
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public GcCreatureIkData(long address) : base(address)
	{

	}
}
