using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
	public class UploadHandler : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(UploadHandler uploadHandler)
			{
				return (IntPtr)0;
			}
		}

		[NonSerialized]
		internal IntPtr m_Ptr;

		[NativeMethod(IsThreadSafe = true)]
		private void ReleaseFromScripting()
		{
		}

		internal UploadHandler()
		{
		}

		~UploadHandler()
		{
		}

		public virtual void Dispose()
		{
		}

		private static void ReleaseFromScripting_Injected(IntPtr _unity_self)
		{
		}
	}
}
