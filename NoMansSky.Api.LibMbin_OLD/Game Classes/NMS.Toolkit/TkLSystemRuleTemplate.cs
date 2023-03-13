using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLSystemRuleTemplate : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x80 LSystem
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public TkLSystemRuleTemplate(long address) : base(address)
	{

	}
}
