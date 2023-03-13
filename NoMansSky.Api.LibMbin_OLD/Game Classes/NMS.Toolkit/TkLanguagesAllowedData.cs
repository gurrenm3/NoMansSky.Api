using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLanguagesAllowedData : NMSTemplate
{
	public VirtualList<TkLanguages> Allowed
	{
		get => cache.GetOrAddValue(new VirtualList<TkLanguages>(address + GetOffset()));
		set => TrySetValue<TkLanguages>(value);
	}

	public TkLanguages Fallback
	{
		get => GetValue<TkLanguages>();
		set => TrySetValue<TkLanguages>(value);
	}

	public TkLanguagesAllowedData(long address) : base(address)
	{

	}
}
