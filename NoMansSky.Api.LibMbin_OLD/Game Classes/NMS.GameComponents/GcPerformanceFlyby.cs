using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPerformanceFlyby : NMSTemplate
{
	public Single Length
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Offset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Locked
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single LockOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPerformanceFlyby(long address) : base(address)
	{

	}
}
