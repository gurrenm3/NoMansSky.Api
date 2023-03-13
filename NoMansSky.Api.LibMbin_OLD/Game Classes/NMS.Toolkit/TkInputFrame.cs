using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkInputFrame : NMSTemplate
{
	public Vector2f LeftStick
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f RightStick
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single LeftTrigger
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RightTrigger
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int16 Buttons
	{
		get => GetValue<Int16>();
		set => TrySetValue<Int16>(value);
	}

	public TkInputFrame(long address) : base(address)
	{

	}
}
