using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMaterialShaderMillFlag : NMSTemplate
{
	public NMSString0x20 Flag
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public TkMaterialShaderMillFlag(long address) : base(address)
	{

	}
}
