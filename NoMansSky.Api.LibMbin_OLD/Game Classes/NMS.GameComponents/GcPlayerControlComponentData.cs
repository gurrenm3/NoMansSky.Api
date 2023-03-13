using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerControlComponentData : NMSTemplate
{
	public NMSString0x10 InitialState
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPlayerControlInput BaseInput
	{
		get => GetValue<GcPlayerControlInput>();
		set => TrySetValue<GcPlayerControlInput>(value);
	}

	public NMSString0x10 BaseCamera
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcPlayerControlState> States
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerControlState>(address + GetOffset()));
		set => TrySetValue<GcPlayerControlState>(value);
	}

	public TkBlackboardKey AimDir
	{
		get => GetValue<TkBlackboardKey>();
		set => TrySetValue<TkBlackboardKey>(value);
	}

	public TkBlackboardKey TorchDir
	{
		get => GetValue<TkBlackboardKey>();
		set => TrySetValue<TkBlackboardKey>(value);
	}

	public TkBlackboardKey CrosshairDir
	{
		get => GetValue<TkBlackboardKey>();
		set => TrySetValue<TkBlackboardKey>(value);
	}

	public GcPlayerControlComponentData(long address) : base(address)
	{

	}
}
