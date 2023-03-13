using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInputBinding : NMSTemplate
{
	public GcInputActions Action
	{
		get => GetValue<GcInputActions>();
		set => TrySetValue<GcInputActions>(value);
	}

	public TkInputEnum Button
	{
		get => GetValue<TkInputEnum>();
		set => TrySetValue<TkInputEnum>(value);
	}

	public TkInputAxisEnum Axis
	{
		get => GetValue<TkInputAxisEnum>();
		set => TrySetValue<TkInputAxisEnum>(value);
	}

	public GcInputBinding(long address) : base(address)
	{

	}
}
