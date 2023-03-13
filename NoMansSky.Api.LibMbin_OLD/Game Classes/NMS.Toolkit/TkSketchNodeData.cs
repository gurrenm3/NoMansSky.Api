using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkSketchNodeData : NMSTemplate
{
	public NMSString0x20 TypeName
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public libMBIN.NMS.Toolkit.TkSketchNodeData.TriggerTypeEnum TriggerType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkSketchNodeData.TriggerTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkSketchNodeData.TriggerTypeEnum>(value);
	}

	public Int32 SelectedVariant
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PositionX
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PositionY
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<TkSketchNodeConnections> Connections
	{
		get => cache.GetOrAddValue(new VirtualList<TkSketchNodeConnections>(address + GetOffset()));
		set => TrySetValue<TkSketchNodeConnections>(value);
	}

	public VirtualList<Byte> CustomData
	{
		get => cache.GetOrAddValue(new VirtualList<Byte>(address + GetOffset()));
		set => TrySetValue<Byte>(value);
	}

	public TkSketchNodeData(long address) : base(address)
	{

	}
}
