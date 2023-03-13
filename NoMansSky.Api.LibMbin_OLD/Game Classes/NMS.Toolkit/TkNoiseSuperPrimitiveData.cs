using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseSuperPrimitiveData : NMSTemplate
{
	public Single Width
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Height
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Depth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Thickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CornerRadiusXY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CornerRadiusZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BottomRadiusOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkNoiseSuperPrimitiveData(long address) : base(address)
	{

	}
}
