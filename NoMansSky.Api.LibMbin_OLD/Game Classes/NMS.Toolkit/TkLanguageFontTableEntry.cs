using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLanguageFontTableEntry : NMSTemplate
{
	public TkLanguages Language
	{
		get => GetValue<TkLanguages>();
		set => TrySetValue<TkLanguages>(value);
	}

	public NMSString0x80 GameFont
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 GameFont2
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 ConsoleFont
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 ConsoleFont2
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public TkLanguageFontTableEntry(long address) : base(address)
	{

	}
}
