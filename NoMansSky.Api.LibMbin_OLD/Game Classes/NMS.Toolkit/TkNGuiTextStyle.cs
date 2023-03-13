using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiTextStyle : NMSTemplate
{
	public TkNGuiTextStyleData Default
	{
		get => GetValue<TkNGuiTextStyleData>();
		set => TrySetValue<TkNGuiTextStyleData>(value);
	}

	public TkNGuiTextStyleData Highlight
	{
		get => GetValue<TkNGuiTextStyleData>();
		set => TrySetValue<TkNGuiTextStyleData>(value);
	}

	public TkNGuiTextStyleData Active
	{
		get => GetValue<TkNGuiTextStyleData>();
		set => TrySetValue<TkNGuiTextStyleData>(value);
	}

	public TkNGuiTextStyle(long address) : base(address)
	{

	}
}
