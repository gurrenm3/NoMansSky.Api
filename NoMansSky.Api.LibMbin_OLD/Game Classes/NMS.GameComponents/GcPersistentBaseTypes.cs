using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPersistentBaseTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPersistentBaseTypes.PersistentBaseTypesEnum PersistentBaseTypes
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPersistentBaseTypes.PersistentBaseTypesEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPersistentBaseTypes.PersistentBaseTypesEnum>(value);
	}

	public GcPersistentBaseTypes(long address) : base(address)
	{

	}
}
