using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSelectableObjectSpawnData : NMSTemplate
{
	public GcResourceElement Resource
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public GcSelectableObjectSpawnData(long address) : base(address)
	{

	}
}
