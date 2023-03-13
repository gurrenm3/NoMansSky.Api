using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkTransformData : NMSTemplate
{
	public Single TransX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TransY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TransZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkTransformData(long address) : base(address)
	{

	}
}
