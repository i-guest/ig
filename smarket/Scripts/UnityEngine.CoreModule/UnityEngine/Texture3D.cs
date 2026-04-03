using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/Texture3D.h")]
	[ExcludeFromPreset]
	public sealed class Texture3D : Texture
	{
		public override bool isReadable => false;

		[NativeName("SetPixel")]
		private void SetPixelImpl(int mip, int x, int y, int z, Color color)
		{
		}

		[FreeFunction("Texture3DScripting::Create")]
		private static bool Internal_CreateImpl([Writable] Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
		{
			return false;
		}

		private static void Internal_Create([Writable] Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
		{
		}

		[FreeFunction(Name = "Texture3DScripting::Apply", HasExplicitThis = true)]
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
		}

		[FreeFunction(Name = "Texture3DScripting::SetPixels", HasExplicitThis = true, ThrowsException = true)]
		public void SetPixels(Color[] colors, int miplevel)
		{
		}

		private IntPtr GetImageData()
		{
			return (IntPtr)0;
		}

		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags)
		{
		}

		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount)
		{
		}

		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags)
		{
		}

		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, [DefaultValue("Texture.GenerateAllMips")] int mipCount)
		{
		}

		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount)
		{
		}

		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex)
		{
		}

		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex, [DefaultValue("false")] bool createUninitialized)
		{
		}

		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
		{
		}

		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool createUninitialized)
		{
		}

		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex)
		{
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

		public void SetPixel(int x, int y, int z, Color color, [DefaultValue("0")] int mipLevel)
		{
		}

		public NativeArray<T> GetPixelData<T>(int mipLevel) where T : struct
		{
			return default(NativeArray<T>);
		}

		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}

		private static bool get_isReadable_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void SetPixelImpl_Injected(IntPtr _unity_self, int mip, int x, int y, int z, [In] ref Color color)
		{
		}

		private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable)
		{
		}

		private static void SetPixels_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel)
		{
		}

		private static IntPtr GetImageData_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}
	}
}
