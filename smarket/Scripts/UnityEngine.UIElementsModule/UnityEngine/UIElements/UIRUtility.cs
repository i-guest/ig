using System;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	internal static class UIRUtility
	{
		private static readonly ProfilerMarker k_ComputeTransformMatrixMarker;

		public static readonly string k_DefaultShaderName;

		[ThreadStatic]
		private static int? s_ThreadIndex;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Rect Encapsulate(Rect a, Rect b)
		{
			return default(Rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Rect InflateByMargins(Rect r, PostProcessingMargins margins)
		{
			return default(Rect);
		}

		private static void ComputeMatrixRelativeToAncestor(RenderData renderData, RenderData ancestor, out Matrix4x4 transform)
		{
			transform = default(Matrix4x4);
		}

		public static void ComputeMatrixRelativeToRenderTree(RenderData renderData, out Matrix4x4 transform)
		{
			transform = default(Matrix4x4);
		}

		public static void GetVerticesTransformInfo(RenderData renderData, out Matrix4x4 transform)
		{
			transform = default(Matrix4x4);
		}

		internal static void ComputeTransformMatrix(RenderData renderData, RenderData ancestor, out Matrix4x4 result)
		{
			result = default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool RectHasArea(Rect rect)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool RectHasArea(RectInt rect)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Rect CastToRect(RectInt rect)
		{
			return default(Rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static RectInt CastToRectInt(Rect rect)
		{
			return default(RectInt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsRoundRect(VisualElement ve)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsVectorImageBackground(VisualElement ve)
		{
			return false;
		}

		public static void Destroy(Object obj)
		{
		}

		public static int GetPrevPow2(int n)
		{
			return 0;
		}

		public static int GetNextPow2(int n)
		{
			return 0;
		}

		public static int GetNextPow2Exp(int n)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetThreadIndex()
		{
			return 0;
		}
	}
}
