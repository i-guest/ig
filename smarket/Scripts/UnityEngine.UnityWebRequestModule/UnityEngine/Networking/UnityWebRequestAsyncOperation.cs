using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	[StructLayout((LayoutKind)0)]
	[UsedByNativeCode]
	[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
	[NativeHeader("UnityWebRequestScriptingClasses.h")]
	public class UnityWebRequestAsyncOperation : AsyncOperation
	{
		internal new static class BindingsMarshaller
		{
			public static UnityWebRequestAsyncOperation ConvertToManaged(IntPtr ptr)
			{
				return null;
			}
		}

		public UnityWebRequest webRequest { get; internal set; }

		private UnityWebRequestAsyncOperation(IntPtr ptr)
			: base((IntPtr)0)
		{
		}
	}
}
