using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVROverride_Text : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcVROverride_Text.VROverride_TextEnum VROverride_Text
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcVROverride_Text.VROverride_TextEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcVROverride_Text.VROverride_TextEnum>(value);
	}

	public Int32 IntValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FloatValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcVROverride_Text(long address) : base(address)
	{

	}
}
