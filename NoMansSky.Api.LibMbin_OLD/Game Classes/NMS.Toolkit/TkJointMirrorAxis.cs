using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkJointMirrorAxis : NMSTemplate
{
	public Single TransMirrorAxisX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TransMirrorAxisY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TransMirrorAxisZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotAdjustX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotAdjustY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotAdjustZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotAdjustW
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotMirrorAxisX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotMirrorAxisY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotMirrorAxisZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MirrorAxisMode
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkJointMirrorAxis(long address) : base(address)
	{

	}
}
