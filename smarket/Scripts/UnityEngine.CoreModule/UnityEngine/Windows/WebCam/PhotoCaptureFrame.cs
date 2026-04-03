using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
	[MovedFrom("UnityEngine.XR.WSA.WebCam")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
	public sealed class PhotoCaptureFrame : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(PhotoCaptureFrame photoCaptureFrame)
			{
				return (IntPtr)0;
			}
		}

		private IntPtr m_NativePtr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003ChasLocationData_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private CapturePixelFormat _003CpixelFormat_003Ek__BackingField;

		public int dataLength { get; private set; }

		private bool hasLocationData
		{
			[CompilerGenerated]
			set
			{
				_003ChasLocationData_003Ek__BackingField = value;
			}
		}

		private CapturePixelFormat pixelFormat
		{
			[CompilerGenerated]
			set
			{
				_003CpixelFormat_003Ek__BackingField = value;
			}
		}

		[ThreadAndSerializationSafe]
		private int GetDataLength()
		{
			return 0;
		}

		[ThreadAndSerializationSafe]
		private bool GetHasLocationData()
		{
			return false;
		}

		[ThreadAndSerializationSafe]
		private CapturePixelFormat GetCapturePixelFormat()
		{
			return default(CapturePixelFormat);
		}

		internal PhotoCaptureFrame(IntPtr nativePtr)
		{
		}

		private void Cleanup()
		{
		}

		[ThreadAndSerializationSafe]
		[NativeName("Dispose")]
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		private void Dispose_Internal()
		{
		}

		public void Dispose()
		{
		}

		~PhotoCaptureFrame()
		{
		}

		private static int GetDataLength_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static bool GetHasLocationData_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static CapturePixelFormat GetCapturePixelFormat_Injected(IntPtr _unity_self)
		{
			return default(CapturePixelFormat);
		}

		private static void Dispose_Internal_Injected(IntPtr _unity_self)
		{
		}
	}
}
