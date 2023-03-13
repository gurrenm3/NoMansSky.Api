using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcClothPiece : NMSTemplate
{
	public Boolean Enabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x40 DebugName
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public NMSString0x40 RenderMeshNodeName
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Int32 NumPointsInRenderMeshI
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumPointsInRenderMeshJ
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 VertexRemappingPermutation
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumSimPointsI
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumSimPointsJ
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ClothHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ParticleRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StaticFriction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DampingWrtFixed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AbsoluteDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StandardGravityScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x40 InitialShapeReferenceBone
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public libMBIN.NMS.GameComponents.GcClothPiece.ScaleInTransformApplicationOnClothEnum ScaleInTransformApplicationOnCloth
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcClothPiece.ScaleInTransformApplicationOnClothEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcClothPiece.ScaleInTransformApplicationOnClothEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcClothPiece.ScaleInTransformApplicationOnCollisionEnum ScaleInTransformApplicationOnCollision
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcClothPiece.ScaleInTransformApplicationOnCollisionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcClothPiece.ScaleInTransformApplicationOnCollisionEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcClothPiece.ScaleInTransformApplicationOnAttachmentEnum ScaleInTransformApplicationOnAttachment
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcClothPiece.ScaleInTransformApplicationOnAttachmentEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcClothPiece.ScaleInTransformApplicationOnAttachmentEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcClothPiece.InitialShapeSourceEnum InitialShapeSource
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcClothPiece.InitialShapeSourceEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcClothPiece.InitialShapeSourceEnum>(value);
	}

	public GcCapeLikeInitialShape CapeLikeInitialShape
	{
		get => GetValue<GcCapeLikeInitialShape>();
		set => TrySetValue<GcCapeLikeInitialShape>(value);
	}

	public GcRectangularInitialShape RectangularInitialShape
	{
		get => GetValue<GcRectangularInitialShape>();
		set => TrySetValue<GcRectangularInitialShape>(value);
	}

	public VirtualList<Vector3f> InitialShapePoints
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualList<GcClothCollisionBone> CollisionBones
	{
		get => cache.GetOrAddValue(new VirtualList<GcClothCollisionBone>(address + GetOffset()));
		set => TrySetValue<GcClothCollisionBone>(value);
	}

	public VirtualList<GcClothAttachmentCirlce> AttachmentCircles
	{
		get => cache.GetOrAddValue(new VirtualList<GcClothAttachmentCirlce>(address + GetOffset()));
		set => TrySetValue<GcClothAttachmentCirlce>(value);
	}

	public VirtualList<GcClothAttachmentLine> AttachmentLines
	{
		get => cache.GetOrAddValue(new VirtualList<GcClothAttachmentLine>(address + GetOffset()));
		set => TrySetValue<GcClothAttachmentLine>(value);
	}

	public VirtualList<GcAttachmentPointSet> AttachmentPointSets
	{
		get => cache.GetOrAddValue(new VirtualList<GcAttachmentPointSet>(address + GetOffset()));
		set => TrySetValue<GcAttachmentPointSet>(value);
	}

	public GcConstraintsToCreateSpec ConstraintsToCreate
	{
		get => GetValue<GcConstraintsToCreateSpec>();
		set => TrySetValue<GcConstraintsToCreateSpec>(value);
	}

	public GcClothAttractor Attractor
	{
		get => GetValue<GcClothAttractor>();
		set => TrySetValue<GcClothAttractor>(value);
	}

	public VirtualList<NMSString0x40> NodesThatMustBePresent
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x40>(address + GetOffset()));
		set => TrySetValue<NMSString0x40>(value);
	}

	public VirtualList<NMSString0x40> NodesToHide
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x40>(address + GetOffset()));
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcAdvancedTweaks Advanced
	{
		get => GetValue<GcAdvancedTweaks>();
		set => TrySetValue<GcAdvancedTweaks>(value);
	}

	public Boolean VertexBasedClothRenderingEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AttachedNodesEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcAttachedNode> AttachedNodes
	{
		get => cache.GetOrAddValue(new VirtualList<GcAttachedNode>(address + GetOffset()));
		set => TrySetValue<GcAttachedNode>(value);
	}

	public Single AttachedNodesOverallBlendStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Int32> DeletedSimPoints
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> DeletedConstraintsI
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> DeletedConstraintsJ
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public Boolean LeaveRenderedTrianglesUnaffected
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcClothPiece(long address) : base(address)
	{

	}
}
