using System;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
	{
		public RenderData owner;

		public RenderChainCommand prev;

		public RenderChainCommand next;

		public CommandType type;

		public CommandFlags flags;

		public Material material;

		public MaterialPropertyBlock userProps;

		public TextureId texture;

		public int stencilRef;

		public float sdfScale;

		public float sharpness;

		public MeshHandle mesh;

		public int indexOffset;

		public int indexCount;

		public Action callback;

		private static ProfilerMarker s_ImmediateOverheadMarker;

		public void Reset()
		{
		}

		public void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException)
		{
		}

		public static void PushScissor(DrawParams drawParams, Rect scissor, float pixelsPerPoint)
		{
		}

		public static void PopScissor(DrawParams drawParams, float pixelsPerPoint)
		{
		}

		private static Rect CombineScissorRects(Rect r0, Rect r1)
		{
			return default(Rect);
		}

		private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint)
		{
			return default(RectInt);
		}
	}
}
