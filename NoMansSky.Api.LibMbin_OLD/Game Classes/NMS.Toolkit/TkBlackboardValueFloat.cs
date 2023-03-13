using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBlackboardValueFloat : NMSTemplate
{
	public NMSString0x10 Key
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Value
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkBlackboardValueFloat(long address) : base(address)
	{

	}
}
