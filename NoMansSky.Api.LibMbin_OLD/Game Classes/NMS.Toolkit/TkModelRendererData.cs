using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkModelRendererData : NMSTemplate
{
	public TkModelRendererCameraData Camera
	{
		get => GetValue<TkModelRendererCameraData>();
		set => TrySetValue<TkModelRendererCameraData>(value);
	}

	public Single Fov
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AspectRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Toolkit.TkModelRendererData.ThumbnailModeEnum ThumbnailMode
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkModelRendererData.ThumbnailModeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkModelRendererData.ThumbnailModeEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkModelRendererData.FocusTypeEnum FocusType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkModelRendererData.FocusTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkModelRendererData.FocusTypeEnum>(value);
	}

	public NMSString0x20A FocusLocator
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Vector3f FocusOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single FocusInterpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BlendInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BlendInOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 Anim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single HeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UsePlayerCameraInHmd
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseSensibleCameraFocusNodeIsNowOffsetNode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LookForFocusInMasterModel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkModelRendererData(long address) : base(address)
	{

	}
}
