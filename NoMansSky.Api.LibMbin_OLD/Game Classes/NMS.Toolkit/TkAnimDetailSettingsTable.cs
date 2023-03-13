using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimDetailSettingsTable : NMSTemplate
{
	public VirtualArray<TkAnimDetailSettings> Table
	{
		get => cache.GetOrAddValue(new VirtualArray<TkAnimDetailSettings>(address + GetOffset(), 4));
		set => TrySetValue<TkAnimDetailSettings>(value);
	}

	public TkAnimDetailSettingsTable(long address) : base(address)
	{

	}
}
