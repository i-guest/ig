using System;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	internal static class RenderEvents
	{
		private static readonly ProfilerMarker k_NudgeVerticesMarker;

		private static readonly float VisibilityTreshold;

		internal static void ProcessOnClippingChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		internal static void ProcessOnOpacityChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		internal static void ProcessOnColorChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		internal static void ProcessOnTransformOrSizeChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		private static Matrix4x4 GetTransformIDTransformInfo(RenderData renderData)
		{
			return default(Matrix4x4);
		}

		private static Vector4 GetClipRectIDClipInfo(RenderData renderData)
		{
			return default(Vector4);
		}

		internal static uint DepthFirstOnChildAdded(RenderTreeManager renderTreeManager, VisualElement parent, VisualElement ve, int index)
		{
			return 0u;
		}

		internal static uint DepthFirstOnElementRemoving(RenderTreeManager renderTreeManager, VisualElement ve)
		{
			return 0u;
		}

		private static void DepthFirstRemoveRenderData(RenderTreeManager renderTreeManager, RenderData renderData)
		{
		}

		private static void DoDepthFirstRemoveRenderData(RenderTreeManager renderTreeManager, RenderData renderData)
		{
		}

		private static void DisconnectSubTree(RenderData renderData)
		{
		}

		private static void DisconnectRenderTreeFromParent(RenderTree parentTree, RenderTree nestedTree)
		{
		}

		private static void ResetRenderData(RenderTreeManager renderTreeManager, RenderData renderData)
		{
		}

		private static void DepthFirstOnClippingChanged(RenderTreeManager renderTreeManager, RenderData parentRenderData, RenderData renderData, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats)
		{
		}

		private static void DepthFirstOnOpacityChanged(RenderTreeManager renderTreeManager, float parentCompositeOpacity, RenderData renderData, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = false)
		{
		}

		private static void OnColorChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		private static void DepthFirstOnTransformOrSizeChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats)
		{
		}

		public static bool UpdateTextCoreSettings(RenderTreeManager renderTreeManager, VisualElement ve)
		{
			return false;
		}

		private static bool NudgeVerticesToNewSpace(RenderData renderData, RenderTreeManager renderTreeManager, UIRenderDevice device)
		{
			return false;
		}

		private static void PrepareNudgeVertices(UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count)
		{
			src = default(IntPtr);
			dst = default(IntPtr);
			count = default(int);
		}

		private static ClipMethod DetermineSelfClipMethod(RenderTreeManager renderTreeManager, RenderData renderData)
		{
			return default(ClipMethod);
		}

		private static bool UpdateLocalFlipsWinding(RenderData renderData)
		{
			return false;
		}

		private static void UpdateZeroScaling(RenderData renderData)
		{
		}

		private static bool NeedsTransformID(VisualElement ve)
		{
			return false;
		}

		internal static bool NeedsColorID(VisualElement ve)
		{
			return false;
		}

		internal static bool NeedsTextCoreSettings(VisualElement ve)
		{
			return false;
		}

		private static bool InitColorIDs(RenderTreeManager renderTreeManager, VisualElement ve)
		{
			return false;
		}

		public static void SetColorValues(RenderTreeManager renderTreeManager, VisualElement ve)
		{
		}
	}
}
