using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerControlInputAxis : NMSTemplate
{
	public GcCharacterControlInputValidity Validity
	{
		get => GetValue<GcCharacterControlInputValidity>();
		set => TrySetValue<GcCharacterControlInputValidity>(value);
	}

	public GcInputActions InputX
	{
		get => GetValue<GcInputActions>();
		set => TrySetValue<GcInputActions>(value);
	}

	public GcInputActions InputY
	{
		get => GetValue<GcInputActions>();
		set => TrySetValue<GcInputActions>(value);
	}

	public GcCharacterControlOutputSpace OutputSpace
	{
		get => GetValue<GcCharacterControlOutputSpace>();
		set => TrySetValue<GcCharacterControlOutputSpace>(value);
	}

	public NMSString0x10 Output
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 OutputLength
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPlayerControlInputAxis(long address) : base(address)
	{

	}
}
