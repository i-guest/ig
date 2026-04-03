using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements.UIR
{
	internal class MeshGenerator : IMeshGenerator, IDisposable
	{
		private struct RepeatRectUV
		{
			public Rect rect;

			public Rect uv;
		}

		public struct BackgroundRepeatInstance
		{
			public Rect rect;

			public Rect backgroundRepeatRect;

			public Rect uv;
		}

		public struct BorderParams
		{
			public Rect rect;

			public Color playmodeTintColor;

			public Color leftColor;

			public Color topColor;

			public Color rightColor;

			public Color bottomColor;

			public float leftWidth;

			public float topWidth;

			public float rightWidth;

			public float bottomWidth;

			public Vector2 topLeftRadius;

			public Vector2 topRightRadius;

			public Vector2 bottomRightRadius;

			public Vector2 bottomLeftRadius;

			internal ColorPage leftColorPage;

			internal ColorPage topColorPage;

			internal ColorPage rightColorPage;

			internal ColorPage bottomColorPage;

			internal void ToNativeParams(out MeshBuilderNative.NativeBorderParams nativeBorderParams)
			{
				nativeBorderParams = default(MeshBuilderNative.NativeBorderParams);
			}
		}

		public struct RectangleParams
		{
			public Rect rect;

			public Rect uv;

			public Color color;

			public Rect subRect;

			public Rect backgroundRepeatRect;

			public NativePagedList<BackgroundRepeatInstance> backgroundRepeatInstanceList;

			public int backgroundRepeatInstanceListStartIndex;

			public int backgroundRepeatInstanceListEndIndex;

			public BackgroundPosition backgroundPositionX;

			public BackgroundPosition backgroundPositionY;

			public BackgroundRepeat backgroundRepeat;

			public BackgroundSize backgroundSize;

			public Texture texture;

			public Sprite sprite;

			public VectorImage vectorImage;

			public ScaleMode scaleMode;

			public Color playmodeTintColor;

			public Vector2 topLeftRadius;

			public Vector2 topRightRadius;

			public Vector2 bottomRightRadius;

			public Vector2 bottomLeftRadius;

			public Vector2 contentSize;

			public Vector2 textureSize;

			public int leftSlice;

			public int topSlice;

			public int rightSlice;

			public int bottomSlice;

			public float sliceScale;

			internal Rect spriteGeomRect;

			public Vector4 rectInset;

			internal ColorPage colorPage;

			internal MeshGenerationContext.MeshFlags meshFlags;

			private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut)
			{
				rectOut = default(Rect);
				uvOut = default(Rect);
			}

			private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut)
			{
				rectOut = default(Rect);
				uvOut = default(Rect);
			}

			internal static Rect RectIntersection(Rect a, Rect b)
			{
				return default(Rect);
			}

			private static Rect ComputeGeomRect(Sprite sprite)
			{
				return default(Rect);
			}

			private static Rect ComputeUVRect(Sprite sprite)
			{
				return default(Rect);
			}

			private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation)
			{
				return default(Rect);
			}

			public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, Color playModeTintColor)
			{
				return default(RectangleParams);
			}

			public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, Color playModeTintColor, bool hasRadius, ref Vector4 slices, bool useForRepeat = false)
			{
				return default(RectangleParams);
			}

			public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, Color playModeTintColor)
			{
				return default(RectangleParams);
			}

			internal bool HasRadius(float epsilon)
			{
				return false;
			}

			internal bool HasSlices(float epsilon)
			{
				return false;
			}

			internal void ToNativeParams(out MeshBuilderNative.NativeRectParams nativeRectParams)
			{
				nativeRectParams = default(MeshBuilderNative.NativeRectParams);
			}
		}

		private struct TessellationJobParameters
		{
			public bool isBorderJob;

			public MeshBuilderNative.NativeRectParams rectParams;

			public BorderParams borderParams;

			public UnsafeMeshGenerationNode node;
		}

		private struct TessellationJob : IJobParallelFor
		{
			[ReadOnly]
			public TempMeshAllocator allocator;

			[ReadOnly]
			public NativeSlice<TessellationJobParameters> jobParameters;

			public void Execute(int i)
			{
			}

			private T ExtractHandle<T>(IntPtr handlePtr) where T : class
			{
				return null;
			}

			private void DrawBorder(UnsafeMeshGenerationNode node, ref BorderParams borderParams)
			{
			}

			private void DrawRectangle(UnsafeMeshGenerationNode node, ref MeshBuilderNative.NativeRectParams rectParams, Texture tex)
			{
			}

			private void DrawSprite(UnsafeMeshGenerationNode node, ref MeshBuilderNative.NativeRectParams rectParams, Sprite sprite)
			{
			}

			private void DrawVectorImage(UnsafeMeshGenerationNode node, ref MeshBuilderNative.NativeRectParams rectParams, VectorImage vi)
			{
			}
		}

		private static readonly MemoryLabel k_MemoryLabel;

		private static readonly ProfilerMarker k_MarkerDrawRectangle;

		private static readonly ProfilerMarker k_MarkerDrawBorder;

		private static readonly ProfilerMarker k_MarkerDrawVectorImage;

		private static readonly ProfilerMarker k_MarkerDrawRectangleRepeat;

		private MeshGenerationContext m_MeshGenerationContext;

		private List<RepeatRectUV>[] m_RepeatRectUVList;

		private NativePagedList<BackgroundRepeatInstance> m_BackgroundRepeatInstanceList;

		private GCHandlePool m_GCHandlePool;

		private NativeArray<TessellationJobParameters> m_JobParameters;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _003CcurrentElement_003Ek__BackingField;

		private TextInfo m_TextInfo;

		private UnityEngine.TextCore.Text.TextGenerationSettings m_Settings;

		private List<NativeSlice<Vertex>> m_VerticesArray;

		private List<NativeSlice<ushort>> m_IndicesArray;

		private List<Texture2D> m_Atlases;

		private List<float> m_SdfScales;

		private List<GlyphRenderMode> m_RenderModes;

		private MeshGenerationCallback m_OnMeshGenerationDelegate;

		private List<TessellationJobParameters> m_TesselationJobParameters;

		public VisualElement currentElement
		{
			[CompilerGenerated]
			set
			{
				_003CcurrentElement_003Ek__BackingField = value;
			}
		}

		public TextJobSystem textJobSystem { get; set; }

		internal bool disposed { get; private set; }

		public MeshGenerator(MeshGenerationContext mgc)
		{
		}

		private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length)
		{
			return default(Vector2);
		}

		public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight)
		{
			topLeft = default(Vector2);
			bottomLeft = default(Vector2);
			topRight = default(Vector2);
			bottomRight = default(Vector2);
		}

		public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams)
		{
		}

		public void DrawText(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Material> materials, List<GlyphRenderMode> renderModes)
		{
		}

		public void DrawText(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Texture2D> atlases, List<GlyphRenderMode> renderModes, List<float> sdfScales)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vertex ConvertTextVertexToUIRVertex(ref TextCoreVertex vertex, Vector2 posOffset, float inverseScale, bool isDynamicColor = false, bool isColorGlyph = false)
		{
			return default(Vertex);
		}

		private void MakeText(Texture texture, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, bool isSdf, float sdfScale, float sharpness, bool multiChannel)
		{
		}

		public void DrawRectangle(RectangleParams rectParams)
		{
		}

		public void DrawBorder(BorderParams borderParams)
		{
		}

		public void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void DoDrawRectangleRepeat(ref RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint)
		{
		}

		private void StampRectangleWithSubRect(RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV, ref NativePagedList<BackgroundRepeatInstance> backgroundRepeatInstanceList)
		{
		}

		private static void AdjustSpriteWinding(Vector2[] vertices, ushort[] indices, NativeSlice<ushort> newIndices)
		{
		}

		public void ScheduleJobs(MeshGenerationContext mgc)
		{
		}

		private void OnMeshGeneration(MeshGenerationContext ctx, object data)
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}
	}
}
