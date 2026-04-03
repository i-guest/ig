using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeClass("UI::CanvasRenderer")]
	[NativeHeader("Modules/UI/CanvasRenderer.h")]
	public sealed class CanvasRenderer : Component
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CisMask_003Ek__BackingField;

		public bool hasPopInstruction
		{
			set
			{
			}
		}

		public int materialCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int popMaterialCount
		{
			set
			{
			}
		}

		public int absoluteDepth => 0;

		public bool hasMoved => false;

		public bool cullTransparentMesh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("ShouldCull", false, TargetType.Function)]
		public bool cull
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector2 clippingSoftness
		{
			set
			{
			}
		}

		public void SetColor(Color color)
		{
		}

		public Color GetColor()
		{
			return default(Color);
		}

		public void EnableRectClipping(Rect rect)
		{
		}

		public void DisableRectClipping()
		{
		}

		public void SetMaterial(Material material, int index)
		{
		}

		public Material GetMaterial(int index)
		{
			return null;
		}

		public void SetPopMaterial(Material material, int index)
		{
		}

		public void SetTexture(Texture texture)
		{
		}

		public void SetSecondaryTextureCount(int size)
		{
		}

		public void SetSecondaryTexture(int index, string name, Texture2D texture)
		{
		}

		public void SetAlphaTexture(Texture texture)
		{
		}

		public void SetMesh(Mesh mesh)
		{
		}

		public void Clear()
		{
		}

		public void SetAlpha(float alpha)
		{
		}

		public void SetMaterial(Material material, Texture texture)
		{
		}

		public Material GetMaterial()
		{
			return null;
		}

		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
		{
		}

		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
		{
		}

		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents)
		{
		}

		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		private static void SplitIndicesStreamsInternal(object verts, object indices)
		{
		}

		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents)
		{
		}

		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices)
		{
		}

		private static void set_hasPopInstruction_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static int get_materialCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_materialCount_Injected(IntPtr _unity_self, int value)
		{
		}

		private static void set_popMaterialCount_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_absoluteDepth_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static bool get_hasMoved_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_cullTransparentMesh_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_cullTransparentMesh_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_cull_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_cull_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void SetColor_Injected(IntPtr _unity_self, [In] ref Color color)
		{
		}

		private static void GetColor_Injected(IntPtr _unity_self, out Color ret)
		{
			ret = default(Color);
		}

		private static void EnableRectClipping_Injected(IntPtr _unity_self, [In] ref Rect rect)
		{
		}

		private static void set_clippingSoftness_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static void DisableRectClipping_Injected(IntPtr _unity_self)
		{
		}

		private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr material, int index)
		{
		}

		private static IntPtr GetMaterial_Injected(IntPtr _unity_self, int index)
		{
			return (IntPtr)0;
		}

		private static void SetPopMaterial_Injected(IntPtr _unity_self, IntPtr material, int index)
		{
		}

		private static void SetTexture_Injected(IntPtr _unity_self, IntPtr texture)
		{
		}

		private static void SetSecondaryTextureCount_Injected(IntPtr _unity_self, int size)
		{
		}

		private static void SetSecondaryTexture_Injected(IntPtr _unity_self, int index, ref ManagedSpanWrapper name, IntPtr texture)
		{
		}

		private static void SetAlphaTexture_Injected(IntPtr _unity_self, IntPtr texture)
		{
		}

		private static void SetMesh_Injected(IntPtr _unity_self, IntPtr mesh)
		{
		}

		private static void Clear_Injected(IntPtr _unity_self)
		{
		}
	}
}
