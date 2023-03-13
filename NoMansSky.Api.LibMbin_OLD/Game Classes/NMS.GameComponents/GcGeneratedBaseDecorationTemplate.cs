using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGeneratedBaseDecorationTemplate : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkModelResource TemplateScene
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxPerRoom
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.GameComponents.GcGeneratedBaseDecorationTemplate.DecorationLayerEnum DecorationLayer
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGeneratedBaseDecorationTemplate.DecorationLayerEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGeneratedBaseDecorationTemplate.DecorationLayerEnum>(value);
	}

	public VirtualList<Int32> InvalidRoomIndexes
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public GcGeneratedBaseDecorationTemplate(long address) : base(address)
	{

	}
}
