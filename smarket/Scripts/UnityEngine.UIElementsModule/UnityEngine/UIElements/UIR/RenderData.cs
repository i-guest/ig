using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.UIR
{
	internal class RenderData
	{
		public VisualElement owner;

		public RenderTree renderTree;

		public RenderData parent;

		public RenderData prevSibling;

		public RenderData nextSibling;

		public RenderData firstChild;

		public RenderData lastChild;

		public RenderData groupTransformAncestor;

		public RenderData boneTransformAncestor;

		public RenderData prevDirty;

		public RenderData nextDirty;

		public RenderDataFlags flags;

		public int depthInRenderTree;

		public RenderDataDirtyTypes dirtiedValues;

		public uint dirtyID;

		public RenderChainCommand firstHeadCommand;

		public RenderChainCommand lastHeadCommand;

		public RenderChainCommand firstTailCommand;

		public RenderChainCommand lastTailCommand;

		public bool localFlipsWinding;

		public bool worldFlipsWinding;

		public bool worldTransformScaleZero;

		public ClipMethod clipMethod;

		public int childrenStencilRef;

		public int childrenMaskDepth;

		public MeshHandle headMesh;

		public MeshHandle tailMesh;

		public Matrix4x4 verticesSpace;

		public BMPAlloc transformID;

		public BMPAlloc clipRectID;

		public BMPAlloc opacityID;

		public BMPAlloc textCoreSettingsID;

		public BMPAlloc colorID;

		public BMPAlloc backgroundColorID;

		public BMPAlloc borderLeftColorID;

		public BMPAlloc borderTopColorID;

		public BMPAlloc borderRightColorID;

		public BMPAlloc borderBottomColorID;

		public BMPAlloc tintColorID;

		public float compositeOpacity;

		public float backgroundAlpha;

		public BasicNode<GraphicEntry> graphicEntries;

		public bool pendingRepaint;

		public bool pendingHierarchicalRepaint;

		private Rect m_ClippingRect;

		private Rect m_ClippingRectMinusGroup;

		private bool m_ClippingRectIsInfinite;

		public bool isGroupTransform
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public bool isIgnoringDynamicColorHint
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public bool hasExtraData
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public bool hasExtraMeshes
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public bool isSubTreeQuad
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public bool isNestedRenderTreeRoot
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public bool isClippingRectDirty
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public Rect clippingRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public Rect clippingRectMinusGroup
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		internal bool clippingRectIsInfinite
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool AllocatesID(BMPAlloc alloc)
		{
			return false;
		}

		public static bool InheritsID(BMPAlloc alloc)
		{
			return false;
		}

		public void Init()
		{
		}

		public void Reset()
		{
		}

		internal void UpdateClippingRect()
		{
		}

		private static Rect IntersectClipRects(Rect rect, Rect parentRect)
		{
			return default(Rect);
		}

		private static void GetLocalClippingRect(VisualElement owner, out Rect localRect)
		{
			localRect = default(Rect);
		}
	}
}
