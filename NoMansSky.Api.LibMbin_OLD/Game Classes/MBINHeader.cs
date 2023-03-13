using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class MBINHeader : NMSTemplate
{
	public UInt32 MagicID
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 FormatID
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt64 Timestamp
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 TemplateGUID
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public string TemplateName
	{
		get => GetValue<String>();
		set => TrySetValue<String>(value);
	}

	public UInt64 EndPadding
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public MBINHeader(long address) : base(address)
	{

	}
}
