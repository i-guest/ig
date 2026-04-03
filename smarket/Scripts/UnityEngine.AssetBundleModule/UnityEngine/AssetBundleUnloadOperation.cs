using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleUnloadOperation.h")]
	[RequiredByNativeCode]
	public class AssetBundleUnloadOperation : AsyncOperation
	{
		internal new static class BindingsMarshaller
		{
			public static AssetBundleUnloadOperation ConvertToManaged(IntPtr ptr)
			{
				return null;
			}

			public static IntPtr ConvertToNative(AssetBundleUnloadOperation assetBundleUnloadOperation)
			{
				return (IntPtr)0;
			}
		}

		[NativeMethod("WaitForCompletion")]
		public void WaitForCompletion()
		{
		}

		private AssetBundleUnloadOperation(IntPtr ptr)
			: base((IntPtr)0)
		{
		}

		private static void WaitForCompletion_Injected(IntPtr _unity_self)
		{
		}
	}
}
