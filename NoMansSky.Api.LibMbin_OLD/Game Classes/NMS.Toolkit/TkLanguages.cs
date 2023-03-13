using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLanguages : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkLanguages.LanguageEnum Language
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkLanguages.LanguageEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkLanguages.LanguageEnum>(value);
	}

	public TkLanguages(long address) : base(address)
	{

	}
}
