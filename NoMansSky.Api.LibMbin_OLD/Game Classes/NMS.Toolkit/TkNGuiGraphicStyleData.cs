using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiGraphicStyleData : NMSTemplate
{
	public Single PaddingX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PaddingY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarginX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarginY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour IconColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour StrokeColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public libMBIN.NMS.Toolkit.TkNGuiGraphicStyleData.ShapeEnum Shape
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNGuiGraphicStyleData.ShapeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNGuiGraphicStyleData.ShapeEnum>(value);
	}

	public Boolean SolidColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HasDropShadow
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HasOuterGradient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HasInnerGradient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Toolkit.TkNGuiGraphicStyleData.GradientEnum Gradient
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNGuiGraphicStyleData.GradientEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNGuiGraphicStyleData.GradientEnum>(value);
	}

	public Single GradientStartOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GradientEndOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean GradientOffsetPercent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour GradientColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single CornerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StrokeSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 Image
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Icon
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single Desaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean StrokeGradient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single StrokeGradientOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StrokeGradientFeather
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour StrokeGradientColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public TkNGuiGraphicStyleData(long address) : base(address)
	{

	}
}
