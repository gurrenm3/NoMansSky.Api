using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceshipComponentData : NMSTemplate
{
	public GcSpaceshipClasses Class
	{
		get => GetValue<GcSpaceshipClasses>();
		set => TrySetValue<GcSpaceshipClasses>(value);
	}

	public NMSString0x80 Cockpit
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single MaxHeadTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeadPitchUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeadPitchDown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 DefaultHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FoVFixedDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkModelRendererData Renderer
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public GcSpaceshipComponentData(long address) : base(address)
	{

	}
}
