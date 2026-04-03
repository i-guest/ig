using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Runtime/Mono/Coroutine.h")]
	[RequiredByNativeCode]
	public sealed class Coroutine : YieldInstruction
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(Coroutine coroutine)
			{
				return (IntPtr)0;
			}
		}

		internal IntPtr m_Ptr;

		private Coroutine()
		{
		}

		~Coroutine()
		{
		}

		[FreeFunction("Coroutine::CleanupCoroutineGC", true)]
		private static void ReleaseCoroutine(IntPtr ptr)
		{
		}
	}
}
