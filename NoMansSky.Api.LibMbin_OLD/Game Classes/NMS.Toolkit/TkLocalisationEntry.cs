using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLocalisationEntry : NMSTemplate
{
	public NMSString0x20A Id
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VariableSizeString English
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString French
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString Italian
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString German
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString Spanish
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString Russian
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString Polish
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString Dutch
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString Portuguese
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString LatinAmericanSpanish
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString BrazilianPortuguese
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString SimplifiedChinese
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString TraditionalChinese
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString TencentChinese
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString Korean
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString Japanese
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString USEnglish
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public TkLocalisationEntry(long address) : base(address)
	{

	}
}
