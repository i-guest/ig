using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
	public class CertificateHandler : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(CertificateHandler handler)
			{
				return (IntPtr)0;
			}
		}

		[NonSerialized]
		internal IntPtr m_Ptr;

		private static IntPtr Create([UnityMarshalAs(NativeType.ScriptingObjectPtr)] CertificateHandler obj)
		{
			return (IntPtr)0;
		}

		[NativeMethod(IsThreadSafe = true)]
		private void ReleaseFromScripting()
		{
		}

		protected CertificateHandler()
		{
		}

		~CertificateHandler()
		{
		}

		protected virtual bool ValidateCertificate(byte[] certificateData)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal bool ValidateCertificateNative(byte[] certificateData)
		{
			return false;
		}

		public void Dispose()
		{
		}

		private static void ReleaseFromScripting_Injected(IntPtr _unity_self)
		{
		}
	}
}
