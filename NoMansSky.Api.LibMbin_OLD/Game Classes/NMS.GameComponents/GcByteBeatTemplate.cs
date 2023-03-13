using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcByteBeatTemplate : NMSTemplate
{
	public Single Weight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcByteBeatToken TokenType
	{
		get => GetValue<GcByteBeatToken>();
		set => TrySetValue<GcByteBeatToken>(value);
	}

	public Int32 MinValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcByteBeatTemplate> Children
	{
		get => cache.GetOrAddValue(new VirtualList<GcByteBeatTemplate>(address + GetOffset()));
		set => TrySetValue<GcByteBeatTemplate>(value);
	}

	public GcByteBeatTemplate(long address) : base(address)
	{

	}
}
