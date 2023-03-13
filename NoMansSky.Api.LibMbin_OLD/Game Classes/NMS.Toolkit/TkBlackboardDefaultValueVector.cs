using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBlackboardDefaultValueVector : NMSTemplate
{
	public TkBlackboardCategory BlackboardCategory
	{
		get => GetValue<TkBlackboardCategory>();
		set => TrySetValue<TkBlackboardCategory>(value);
	}

	public NMSString0x10 BlackboardKey
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Vector3f DefaultValue
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public TkBlackboardDefaultValueVector(long address) : base(address)
	{

	}
}
