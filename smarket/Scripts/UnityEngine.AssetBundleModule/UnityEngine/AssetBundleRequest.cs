using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
	[RequiredByNativeCode]
	public class AssetBundleRequest : ResourceRequest
	{
		internal new static class BindingsMarshaller
		{
			public static AssetBundleRequest ConvertToManaged(IntPtr ptr)
			{
				return null;
			}

			public static IntPtr ConvertToNative(AssetBundleRequest request)
			{
				return (IntPtr)0;
			}
		}

		public Object asset => null;

		public Object[] allAssets
		{
			[NativeMethod("GetAllLoadedAssets")]
			get
			{
				return null;
			}
		}

		[NativeMethod("GetLoadedAsset")]
		protected override Object GetResult()
		{
			return null;
		}

		private AssetBundleRequest(IntPtr ptr)
			: base((IntPtr)0)
		{
		}

		private static IntPtr GetResult_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static Object[] get_allAssets_Injected(IntPtr _unity_self)
		{
			return null;
		}
	}
}
