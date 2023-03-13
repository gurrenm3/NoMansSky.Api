using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSmokeBotStats : NMSTemplate
{
	public Single AvgCpuFPS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinCpuFPS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxCpuFPS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f MinCpuFPSPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f MinCpuFPSFacing
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single AvgGpuFPS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinGpuFPS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxGpuFPS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f MinGpuFPSPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f MinGpuFPSFacing
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single MinMemory
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f MinMemoryPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f MinMemoryFacing
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single TotalCpuFps
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TotalGpuFps
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 FrameCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSmokeBotStats(long address) : base(address)
	{

	}
}
