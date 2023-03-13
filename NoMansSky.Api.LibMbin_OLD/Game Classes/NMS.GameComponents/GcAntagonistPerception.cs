using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAntagonistPerception : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Range
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single XFOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single YFOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcAntagonistPerception.ViewShapeEnum ViewShape
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAntagonistPerception.ViewShapeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAntagonistPerception.ViewShapeEnum>(value);
	}

	public Boolean Raycast
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 SenseLocator
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcAntagonistPerception(long address) : base(address)
	{

	}
}
