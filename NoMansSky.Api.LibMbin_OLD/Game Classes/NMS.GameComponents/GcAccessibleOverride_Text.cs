using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAccessibleOverride_Text : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAccessibleOverride_Text.AccessibleOverride_TextEnum AccessibleOverride_Text
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAccessibleOverride_Text.AccessibleOverride_TextEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAccessibleOverride_Text.AccessibleOverride_TextEnum>(value);
	}

	public Single FloatValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAccessibleOverride_Text(long address) : base(address)
	{

	}
}
