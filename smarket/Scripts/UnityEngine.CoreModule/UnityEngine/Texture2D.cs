using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[HelpURL("texture-type-default")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Graphics/Texture2D.h")]
	public sealed class Texture2D : Texture
	{
		internal const int streamingMipmapsPriorityMin = -128;

		internal const int streamingMipmapsPriorityMax = 127;

		public TextureFormat format
		{
			[NativeName("GetTextureFormat")]
			get
			{
				return default(TextureFormat);
			}
		}

		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static Texture2D whiteTexture => null;

		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static Texture2D blackTexture => null;

		public override bool isReadable => false;

		[FreeFunction("Texture2DScripting::CreateEmpty")]
		private static bool Internal_CreateEmptyImpl([Writable] Texture2D mono)
		{
			return false;
		}

		[FreeFunction("Texture2DScripting::Create")]
		private static bool Internal_CreateImpl([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName)
		{
			return false;
		}

		private static void Internal_Create([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName)
		{
		}

		[NativeName("Apply")]
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
		}

		[NativeName("Reinitialize")]
		private bool ReinitializeImpl(int width, int height)
		{
			return false;
		}

		[NativeName("SetPixel")]
		private void SetPixelImpl(int image, int mip, int x, int y, Color color)
		{
		}

		[NativeName("GetPixelBilinear")]
		private Color GetPixelBilinearImpl(int image, int mip, float u, float v)
		{
			return default(Color);
		}

		[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = true)]
		private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap)
		{
			return false;
		}

		[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = true)]
		private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps)
		{
		}

		[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = true, ThrowsException = true)]
		private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame)
		{
		}

		[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = true)]
		private bool LoadRawTextureDataImplArray(byte[] data)
		{
			return false;
		}

		private IntPtr GetWritableImageData(int frame)
		{
			return (IntPtr)0;
		}

		private ulong GetImageDataSize()
		{
			return 0uL;
		}

		[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = true, ThrowsException = true)]
		private void SetAllPixels32(Color32[] colors, int miplevel)
		{
		}

		[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = true, ThrowsException = true)]
		public byte[] GetRawTextureData()
		{
			return null;
		}

		[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = true, ThrowsException = true)]
		public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel)
		{
			return null;
		}

		[ExcludeFromDocs]
		public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight)
		{
			return null;
		}

		[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = true, ThrowsException = true)]
		public Color32[] GetPixels32([DefaultValue("0")] int miplevel)
		{
			return null;
		}

		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			return null;
		}

		internal bool ValidateFormat(TextureFormat format, int width, int height)
		{
			return false;
		}

		internal bool ValidateFormat(GraphicsFormat format, int width, int height)
		{
			return false;
		}

		internal Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, MipmapLimitDescriptor mipmapLimitDescriptor)
		{
		}

		[ExcludeFromDocs]
		public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags)
		{
		}

		[ExcludeFromDocs]
		public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags)
		{
		}

		internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor)
		{
		}

		public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("-1")] int mipCount, [DefaultValue("false")] bool linear)
		{
		}

		public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("true")] bool mipChain, [DefaultValue("false")] bool linear)
		{
		}

		public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain)
		{
		}

		public Texture2D(int width, int height)
		{
		}

		[ExcludeFromDocs]
		public void SetPixel(int x, int y, Color color)
		{
		}

		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue("0")] int miplevel)
		{
		}

		[ExcludeFromDocs]
		public void SetPixels(Color[] colors)
		{
		}

		[ExcludeFromDocs]
		public Color GetPixelBilinear(float u, float v)
		{
			return default(Color);
		}

		public void LoadRawTextureData(byte[] data)
		{
		}

		public NativeArray<T> GetRawTextureData<T>() where T : struct
		{
			return default(NativeArray<T>);
		}

		public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable)
		{
		}

		[ExcludeFromDocs]
		public void Apply(bool updateMipmaps)
		{
		}

		[ExcludeFromDocs]
		public void Apply()
		{
		}

		public bool Reinitialize(int width, int height)
		{
			return false;
		}

		public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap)
		{
			return false;
		}

		public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps)
		{
		}

		[ExcludeFromDocs]
		public void ReadPixels(Rect source, int destX, int destY)
		{
		}

		public void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel)
		{
		}

		[ExcludeFromDocs]
		public void SetPixels32(Color32[] colors)
		{
		}

		private static TextureFormat get_format_Injected(IntPtr _unity_self)
		{
			return default(TextureFormat);
		}

		private static IntPtr get_whiteTexture_Injected()
		{
			return (IntPtr)0;
		}

		private static IntPtr get_blackTexture_Injected()
		{
			return (IntPtr)0;
		}

		private static bool Internal_CreateImpl_Injected([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName)
		{
			return false;
		}

		private static bool get_isReadable_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable)
		{
		}

		private static bool ReinitializeImpl_Injected(IntPtr _unity_self, int width, int height)
		{
			return false;
		}

		private static void SetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, [In] ref Color color)
		{
		}

		private static void GetPixelBilinearImpl_Injected(IntPtr _unity_self, int image, int mip, float u, float v, out Color ret)
		{
			ret = default(Color);
		}

		private static bool ReinitializeWithTextureFormatImpl_Injected(IntPtr _unity_self, int width, int height, TextureFormat textureFormat, bool hasMipMap)
		{
			return false;
		}

		private static void ReadPixelsImpl_Injected(IntPtr _unity_self, [In] ref Rect source, int destX, int destY, bool recalculateMipMaps)
		{
		}

		private static void SetPixelsImpl_Injected(IntPtr _unity_self, int x, int y, int w, int h, ref ManagedSpanWrapper pixel, int miplevel, int frame)
		{
		}

		private static bool LoadRawTextureDataImplArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper data)
		{
			return false;
		}

		private static IntPtr GetWritableImageData_Injected(IntPtr _unity_self, int frame)
		{
			return (IntPtr)0;
		}

		private static ulong GetImageDataSize_Injected(IntPtr _unity_self)
		{
			return 0uL;
		}

		private static void SetAllPixels32_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel)
		{
		}

		private static byte[] GetRawTextureData_Injected(IntPtr _unity_self)
		{
			return null;
		}

		private static Color[] GetPixels_Injected(IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel)
		{
			return null;
		}

		private static Color32[] GetPixels32_Injected(IntPtr _unity_self, [DefaultValue("0")] int miplevel)
		{
			return null;
		}
	}
}
