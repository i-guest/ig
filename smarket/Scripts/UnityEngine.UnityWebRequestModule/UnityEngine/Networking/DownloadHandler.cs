using System;
using System.Runtime.InteropServices;
using System.Text;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
	public class DownloadHandler : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(DownloadHandler handler)
			{
				return (IntPtr)0;
			}
		}

		[NonSerialized]
		[VisibleToOtherModules]
		internal IntPtr m_Ptr;

		public string error => null;

		public byte[] data => null;

		public string text => null;

		[NativeMethod(IsThreadSafe = true)]
		private void ReleaseFromScripting()
		{
		}

		[VisibleToOtherModules]
		internal DownloadHandler()
		{
		}

		~DownloadHandler()
		{
		}

		public virtual void Dispose()
		{
		}

		private string GetErrorMsg()
		{
			return null;
		}

		protected virtual NativeArray<byte> GetNativeData()
		{
			return default(NativeArray<byte>);
		}

		protected virtual byte[] GetData()
		{
			return null;
		}

		protected virtual string GetText()
		{
			return null;
		}

		private Encoding GetTextEncoder()
		{
			return null;
		}

		private string GetContentType()
		{
			return null;
		}

		[RequiredByNativeCode]
		protected virtual bool ReceiveData(byte[] data, int dataLength)
		{
			return false;
		}

		[RequiredByNativeCode]
		protected virtual void ReceiveContentLengthHeader(ulong contentLength)
		{
		}

		[Obsolete("Use ReceiveContentLengthHeader")]
		protected virtual void ReceiveContentLength(int contentLength)
		{
		}

		[RequiredByNativeCode]
		protected virtual void CompleteContent()
		{
		}

		[RequiredByNativeCode]
		protected virtual float GetProgress()
		{
			return 0f;
		}

		protected static T GetCheckedDownloader<T>(UnityWebRequest www)
		{
			return default(T);
		}

		[VisibleToOtherModules]
		[NativeThrows]
		internal unsafe static byte* InternalGetByteArray(DownloadHandler dh, out int length)
		{
			length = default(int);
			return null;
		}

		internal static byte[] InternalGetByteArray(DownloadHandler dh)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule" })]
		internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray)
		{
			return default(NativeArray<byte>);
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule" })]
		internal static void DisposeNativeArray(ref NativeArray<byte> data)
		{
		}

		internal unsafe static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length)
		{
		}

		private static void ReleaseFromScripting_Injected(IntPtr _unity_self)
		{
		}

		private static void GetErrorMsg_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void GetContentType_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private unsafe static byte* InternalGetByteArray_Injected(IntPtr dh, out int length)
		{
			length = default(int);
			return null;
		}
	}
}
