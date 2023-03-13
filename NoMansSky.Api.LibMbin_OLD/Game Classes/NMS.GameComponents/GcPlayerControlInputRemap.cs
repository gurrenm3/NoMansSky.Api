using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerControlInputRemap : NMSTemplate
{
	public GcCharacterControlInputValidity Validity
	{
		get => GetValue<GcCharacterControlInputValidity>();
		set => TrySetValue<GcCharacterControlInputValidity>(value);
	}

	public GcInputActions Action
	{
		get => GetValue<GcInputActions>();
		set => TrySetValue<GcInputActions>(value);
	}

	public GcInputActions CanBeTriggeredBy
	{
		get => GetValue<GcInputActions>();
		set => TrySetValue<GcInputActions>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlayerControlInputRemap.InputRemapModeEnum InputRemapMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerControlInputRemap.InputRemapModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerControlInputRemap.InputRemapModeEnum>(value);
	}

	public GcPlayerControlInputRemap(long address) : base(address)
	{

	}
}
