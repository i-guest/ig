using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
	public static class ImageConversion
	{
		[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = true, ThrowsException = true)]
		public static byte[] EncodeToPNG(this Texture2D tex)
		{
			return null;
		}

		[NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = true, ThrowsException = true)]
		public static byte[] EncodeToJPG(this Texture2D tex, int quality)
		{
			return null;
		}

		[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = true)]
		public static bool LoadImage([NotNull] this Texture2D tex, ReadOnlySpan<byte> data, bool markNonReadable)
		{
			return false;
		}

		public static bool LoadImage(this Texture2D tex, byte[] data)
		{
			return false;
		}

		private static void EncodeToPNG_Injected(IntPtr tex, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void EncodeToJPG_Injected(IntPtr tex, int quality, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static bool LoadImage_Injected(IntPtr tex, ref ManagedSpanWrapper data, bool markNonReadable)
		{
			return false;
		}
	}
}
