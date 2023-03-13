using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkInputFrameArray : NMSTemplate
{
	public VirtualArray<TkInputFrame> Array
	{
		get => cache.GetOrAddValue(new VirtualArray<TkInputFrame>(address + GetOffset(), 20000));
		set => TrySetValue<TkInputFrame>(value);
	}

	public TkInputFrameArray(long address) : base(address)
	{

	}
}
