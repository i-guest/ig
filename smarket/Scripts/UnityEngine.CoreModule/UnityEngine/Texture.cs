using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/Texture.h")]
	[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
	[UsedByNativeCode]
	public class Texture : Object
	{
		public static readonly int GenerateAllMips;

		public int mipmapCount
		{
			[NativeName("GetMipmapCount")]
			get
			{
				return 0;
			}
		}

		[NativeProperty("AnisoLimit")]
		public static AnisotropicFiltering anisotropicFiltering
		{
			get
			{
				return default(AnisotropicFiltering);
			}
			set
			{
			}
		}

		public virtual GraphicsFormat graphicsFormat => default(GraphicsFormat);

		public virtual int width
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int height
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual TextureDimension dimension
		{
			get
			{
				return default(TextureDimension);
			}
			set
			{
			}
		}

		public virtual bool isReadable => false;

		public TextureWrapMode wrapMode
		{
			[NativeName("GetWrapModeU")]
			get
			{
				return default(TextureWrapMode);
			}
			set
			{
			}
		}

		public TextureWrapMode wrapModeU
		{
			get
			{
				return default(TextureWrapMode);
			}
			set
			{
			}
		}

		public TextureWrapMode wrapModeV
		{
			get
			{
				return default(TextureWrapMode);
			}
			set
			{
			}
		}

		public TextureWrapMode wrapModeW
		{
			get
			{
				return default(TextureWrapMode);
			}
			set
			{
			}
		}

		public FilterMode filterMode
		{
			get
			{
				return default(FilterMode);
			}
			set
			{
			}
		}

		public int anisoLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float mipMapBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 texelSize
		{
			[NativeName("GetTexelSize")]
			get
			{
				return default(Vector2);
			}
		}

		public uint updateCount => 0u;

		internal ColorSpace activeTextureColorSpace
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
			get
			{
				return default(ColorSpace);
			}
		}

		public static bool streamingTextureForceLoadAll
		{
			[FreeFunction(Name = "GetTextureStreamingManager().GetForceLoadAll")]
			get
			{
				return false;
			}
			[FreeFunction(Name = "GetTextureStreamingManager().SetForceLoadAll")]
			set
			{
			}
		}

		public static bool streamingTextureDiscardUnusedMips
		{
			[FreeFunction(Name = "GetTextureStreamingManager().GetDiscardUnusedMips")]
			get
			{
				return false;
			}
			[FreeFunction(Name = "GetTextureStreamingManager().SetDiscardUnusedMips")]
			set
			{
			}
		}

		public static bool allowThreadedTextureCreation
		{
			[FreeFunction(Name = "Texture2DScripting::IsCreateTextureThreadedEnabled")]
			get
			{
				return false;
			}
			[FreeFunction(Name = "Texture2DScripting::EnableCreateTextureThreaded")]
			set
			{
			}
		}

		protected Texture()
		{
		}

		[ThreadSafe]
		private int GetDataWidth()
		{
			return 0;
		}

		[ThreadSafe]
		private int GetDataHeight()
		{
			return 0;
		}

		[ThreadSafe]
		private TextureDimension GetDimension()
		{
			return default(TextureDimension);
		}

		public void IncrementUpdateCount()
		{
		}

		[NativeMethod("GetActiveTextureColorSpace")]
		private int Internal_GetActiveTextureColorSpace()
		{
			return 0;
		}

		[FreeFunction("GetTextureStreamingManager().SetStreamingTextureMaterialDebugPropertiesWithSlot")]
		private static void SetStreamingTextureMaterialDebugPropertiesWithSlot(int materialTextureSlot)
		{
		}

		public static void SetStreamingTextureMaterialDebugProperties(int materialTextureSlot)
		{
		}

		internal ulong GetPixelDataSize(int mipLevel, int element = 0)
		{
			return 0uL;
		}

		internal ulong GetPixelDataOffset(int mipLevel, int element = 0)
		{
			return 0uL;
		}

		internal TextureColorSpace GetTextureColorSpace(bool linear)
		{
			return default(TextureColorSpace);
		}

		internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format)
		{
			return default(TextureColorSpace);
		}

		internal bool ValidateFormat(TextureFormat format)
		{
			return false;
		}

		internal bool ValidateFormat(GraphicsFormat format, GraphicsFormatUsage usage)
		{
			return false;
		}

		internal UnityException CreateNonReadableException(Texture t)
		{
			return null;
		}

		internal UnityException CreateNativeArrayLengthOverflowException()
		{
			return null;
		}

		private static int get_mipmapCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int GetDataWidth_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int GetDataHeight_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static TextureDimension GetDimension_Injected(IntPtr _unity_self)
		{
			return default(TextureDimension);
		}

		private static bool get_isReadable_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static TextureWrapMode get_wrapMode_Injected(IntPtr _unity_self)
		{
			return default(TextureWrapMode);
		}

		private static void set_wrapMode_Injected(IntPtr _unity_self, TextureWrapMode value)
		{
		}

		private static TextureWrapMode get_wrapModeU_Injected(IntPtr _unity_self)
		{
			return default(TextureWrapMode);
		}

		private static void set_wrapModeU_Injected(IntPtr _unity_self, TextureWrapMode value)
		{
		}

		private static TextureWrapMode get_wrapModeV_Injected(IntPtr _unity_self)
		{
			return default(TextureWrapMode);
		}

		private static void set_wrapModeV_Injected(IntPtr _unity_self, TextureWrapMode value)
		{
		}

		private static TextureWrapMode get_wrapModeW_Injected(IntPtr _unity_self)
		{
			return default(TextureWrapMode);
		}

		private static void set_wrapModeW_Injected(IntPtr _unity_self, TextureWrapMode value)
		{
		}

		private static FilterMode get_filterMode_Injected(IntPtr _unity_self)
		{
			return default(FilterMode);
		}

		private static void set_filterMode_Injected(IntPtr _unity_self, FilterMode value)
		{
		}

		private static int get_anisoLevel_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_anisoLevel_Injected(IntPtr _unity_self, int value)
		{
		}

		private static float get_mipMapBias_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_mipMapBias_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void get_texelSize_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static uint get_updateCount_Injected(IntPtr _unity_self)
		{
			return 0u;
		}

		private static void IncrementUpdateCount_Injected(IntPtr _unity_self)
		{
		}

		private static int Internal_GetActiveTextureColorSpace_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static ulong GetPixelDataSize_Injected(IntPtr _unity_self, int mipLevel, int element)
		{
			return 0uL;
		}

		private static ulong GetPixelDataOffset_Injected(IntPtr _unity_self, int mipLevel, int element)
		{
			return 0uL;
		}
	}
}
