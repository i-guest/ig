using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
	public sealed class Texture2DArray : Texture
	{
		public static int allSlices
		{
			[NativeName("GetAllTextureLayersIdentifier")]
			get
			{
				return 0;
			}
		}

		public override bool isReadable => false;

		[FreeFunction("Texture2DArrayScripting::Create")]
		private static bool Internal_CreateImpl([Writable] Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName)
		{
			return false;
		}

		private static void Internal_Create([Writable] Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName)
		{
		}

		internal bool ValidateFormat(TextureFormat format, int width, int height)
		{
			return false;
		}

		internal bool ValidateFormat(GraphicsFormat format, int width, int height)
		{
			return false;
		}

		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags)
		{
		}

		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount)
		{
		}

		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor)
		{
		}

		[RequiredByNativeCode]
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags)
		{
		}

		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		{
		}

		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor)
		{
		}

		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor)
		{
		}

		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized)
		{
		}

		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear)
		{
		}

		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool linear, [DefaultValue("false")] bool createUninitialized)
		{
		}

		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool linear)
		{
		}

		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
		{
		}

		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}

		private static bool get_isReadable_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool Internal_CreateImpl_Injected([Writable] Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName)
		{
			return false;
		}
	}
}
