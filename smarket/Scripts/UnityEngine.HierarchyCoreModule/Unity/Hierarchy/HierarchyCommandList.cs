using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Hierarchy
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/HierarchyCore/Public/HierarchyCommandList.h")]
	[NativeHeader("Modules/HierarchyCore/HierarchyCommandListBindings.h")]
	[RequiredByNativeCode]
	public sealed class HierarchyCommandList : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToUnmanaged(HierarchyCommandList cmdList)
			{
				return (IntPtr)0;
			}
		}

		private IntPtr m_Ptr;

		private readonly bool m_IsOwner;

		private HierarchyCommandList(IntPtr nativePtr)
		{
		}

		~HierarchyCommandList()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static HierarchyCommandList FromIntPtr(IntPtr handlePtr)
		{
			return null;
		}

		[FreeFunction("HierarchyCommandListBindings::Destroy", IsThreadSafe = true)]
		private static void Destroy(IntPtr nativePtr)
		{
		}

		[RequiredByNativeCode]
		private static IntPtr CreateCommandList(IntPtr nativePtr)
		{
			return (IntPtr)0;
		}
	}
}
