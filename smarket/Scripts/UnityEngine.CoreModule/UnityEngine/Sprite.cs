using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[ExcludeFromPreset]
	[NativeType("Runtime/Graphics/SpriteFrame.h")]
	[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
	public sealed class Sprite : Object
	{
		public Bounds bounds => default(Bounds);

		public Rect rect => default(Rect);

		public Vector4 border => default(Vector4);

		public Texture2D texture => null;

		public float pixelsPerUnit
		{
			[NativeMethod("GetPixelsToUnits")]
			get
			{
				return 0f;
			}
		}

		public Texture2D associatedAlphaSplitTexture
		{
			[NativeMethod("GetAlphaTexture")]
			get
			{
				return null;
			}
		}

		public Vector2 pivot
		{
			[NativeMethod("GetPivotInPixels")]
			get
			{
				return default(Vector2);
			}
		}

		public bool packed => false;

		public SpritePackingRotation packingRotation => default(SpritePackingRotation);

		public Vector2[] vertices
		{
			[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = true)]
			get
			{
				return null;
			}
		}

		public ushort[] triangles
		{
			[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = true)]
			get
			{
				return null;
			}
		}

		public Vector2[] uv
		{
			[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = true)]
			get
			{
				return null;
			}
		}

		[RequiredByNativeCode]
		private Sprite()
		{
		}

		internal int GetPackingRotation()
		{
			return 0;
		}

		internal int GetPacked()
		{
			return 0;
		}

		internal Vector4 GetInnerUVs()
		{
			return default(Vector4);
		}

		internal Vector4 GetOuterUVs()
		{
			return default(Vector4);
		}

		internal Vector4 GetPadding()
		{
			return default(Vector4);
		}

		[FreeFunction("SpritesBindings::CreateSprite", ThrowsException = true)]
		internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, [UnityMarshalAs(NativeType.ScriptingObjectPtr)] SecondarySpriteTexture[] secondaryTexture)
		{
			return null;
		}

		public int GetSecondaryTextureCount()
		{
			return 0;
		}

		[FreeFunction("SpritesBindings::GetSecondaryTextures", ThrowsException = true, HasExplicitThis = true)]
		public int GetSecondaryTextures([NotNull][UnityMarshalAs(NativeType.ScriptingObjectPtr)] SecondarySpriteTexture[] secondaryTexture)
		{
			return 0;
		}

		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
		{
			return null;
		}

		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures)
		{
			return null;
		}

		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border)
		{
			return null;
		}

		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
		{
			return null;
		}

		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
		{
			return null;
		}

		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
		{
			return null;
		}

		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
		{
			return null;
		}

		private static int GetPackingRotation_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int GetPacked_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void GetInnerUVs_Injected(IntPtr _unity_self, out Vector4 ret)
		{
			ret = default(Vector4);
		}

		private static void GetOuterUVs_Injected(IntPtr _unity_self, out Vector4 ret)
		{
			ret = default(Vector4);
		}

		private static void GetPadding_Injected(IntPtr _unity_self, out Vector4 ret)
		{
			ret = default(Vector4);
		}

		private static IntPtr CreateSprite_Injected(IntPtr texture, [In] ref Rect rect, [In] ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, [In] ref Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture)
		{
			return (IntPtr)0;
		}

		private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret)
		{
			ret = default(Bounds);
		}

		private static void get_rect_Injected(IntPtr _unity_self, out Rect ret)
		{
			ret = default(Rect);
		}

		private static void get_border_Injected(IntPtr _unity_self, out Vector4 ret)
		{
			ret = default(Vector4);
		}

		private static IntPtr get_texture_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static int GetSecondaryTextureCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int GetSecondaryTextures_Injected(IntPtr _unity_self, SecondarySpriteTexture[] secondaryTexture)
		{
			return 0;
		}

		private static float get_pixelsPerUnit_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static IntPtr get_associatedAlphaSplitTexture_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static Vector2[] get_vertices_Injected(IntPtr _unity_self)
		{
			return null;
		}

		private static ushort[] get_triangles_Injected(IntPtr _unity_self)
		{
			return null;
		}

		private static Vector2[] get_uv_Injected(IntPtr _unity_self)
		{
			return null;
		}
	}
}
