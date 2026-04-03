using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
	[RequiredByNativeCode]
	public class AssetBundleCreateRequest : AsyncOperation
	{
		internal new static class BindingsMarshaller
		{
			public static AssetBundleCreateRequest ConvertToManaged(IntPtr ptr)
			{
				return null;
			}

			public static IntPtr ConvertToNative(AssetBundleCreateRequest assetBundleCreateRequest)
			{
				return (IntPtr)0;
			}
		}

		public AssetBundle assetBundle
		{
			[NativeMethod("GetAssetBundleBlocking")]
			get
			{
				return null;
			}
		}

		private AssetBundleCreateRequest(IntPtr ptr)
			: base((IntPtr)0)
		{
		}

		private static IntPtr get_assetBundle_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}
	}
}
