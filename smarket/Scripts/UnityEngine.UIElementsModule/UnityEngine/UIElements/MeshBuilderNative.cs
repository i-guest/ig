using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRMeshBuilder.bindings.h")]
	internal static class MeshBuilderNative
	{
		public struct NativeColorPage
		{
			public int isValid;

			public Color32 pageAndID;
		}

		public struct NativeBorderParams
		{
			public Rect rect;

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

			internal NativeColorPage leftColorPage;

			internal NativeColorPage topColorPage;

			internal NativeColorPage rightColorPage;

			internal NativeColorPage bottomColorPage;
		}

		public struct NativeRectParams
		{
			public Rect rect;

			public Rect subRect;

			public Rect uv;

			public Color color;

			public ScaleMode scaleMode;

			public IntPtr backgroundRepeatInstanceList;

			public int backgroundRepeatInstanceListStartIndex;

			public int backgroundRepeatInstanceListEndIndex;

			public Vector2 topLeftRadius;

			public Vector2 topRightRadius;

			public Vector2 bottomRightRadius;

			public Vector2 bottomLeftRadius;

			public Rect backgroundRepeatRect;

			public IntPtr texture;

			public IntPtr sprite;

			public IntPtr vectorImage;

			public IntPtr spriteTexture;

			public IntPtr spriteVertices;

			public IntPtr spriteUVs;

			public IntPtr spriteTriangles;

			public Rect spriteGeomRect;

			public Vector2 contentSize;

			public Vector2 textureSize;

			public float texturePixelsPerPoint;

			public int leftSlice;

			public int topSlice;

			public int rightSlice;

			public int bottomSlice;

			public float sliceScale;

			public Vector4 rectInset;

			public NativeColorPage colorPage;

			public int meshFlags;
		}

		[ThreadSafe]
		public static MeshWriteDataInterface MakeBorder(ref NativeBorderParams borderParams)
		{
			return default(MeshWriteDataInterface);
		}

		[ThreadSafe]
		public static MeshWriteDataInterface MakeSolidRect(ref NativeRectParams rectParams)
		{
			return default(MeshWriteDataInterface);
		}

		[ThreadSafe]
		public static MeshWriteDataInterface MakeTexturedRect(ref NativeRectParams rectParams)
		{
			return default(MeshWriteDataInterface);
		}

		[ThreadSafe]
		public static MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage)
		{
			return default(MeshWriteDataInterface);
		}

		[ThreadSafe]
		public static MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, NativeColorPage colorPage)
		{
			return default(MeshWriteDataInterface);
		}

		private static void MakeBorder_Injected(ref NativeBorderParams borderParams, out MeshWriteDataInterface ret)
		{
			ret = default(MeshWriteDataInterface);
		}

		private static void MakeSolidRect_Injected(ref NativeRectParams rectParams, out MeshWriteDataInterface ret)
		{
			ret = default(MeshWriteDataInterface);
		}

		private static void MakeTexturedRect_Injected(ref NativeRectParams rectParams, out MeshWriteDataInterface ret)
		{
			ret = default(MeshWriteDataInterface);
		}

		private static void MakeVectorGraphicsStretchBackground_Injected(ref ManagedSpanWrapper svgVertices, ref ManagedSpanWrapper svgIndices, float svgWidth, float svgHeight, [In] ref Rect targetRect, [In] ref Rect sourceUV, ScaleMode scaleMode, [In] ref Color tint, [In] ref NativeColorPage colorPage, out MeshWriteDataInterface ret)
		{
			ret = default(MeshWriteDataInterface);
		}

		private static void MakeVectorGraphics9SliceBackground_Injected(ref ManagedSpanWrapper svgVertices, ref ManagedSpanWrapper svgIndices, float svgWidth, float svgHeight, [In] ref Rect targetRect, [In] ref Vector4 sliceLTRB, [In] ref Color tint, [In] ref NativeColorPage colorPage, out MeshWriteDataInterface ret)
		{
			ret = default(MeshWriteDataInterface);
		}
	}
}
