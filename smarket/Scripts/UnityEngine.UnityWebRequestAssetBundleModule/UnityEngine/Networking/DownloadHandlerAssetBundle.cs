using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityWebRequestAssetBundle/Public/DownloadHandlerAssetBundle.h")]
	public sealed class DownloadHandlerAssetBundle : DownloadHandler
	{
		internal new static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(DownloadHandlerAssetBundle handler)
			{
				return (IntPtr)0;
			}
		}

		public AssetBundle assetBundle => null;

		public bool autoLoadAssetBundle
		{
			get
			{
				return false;
			}
			[NativeThrows]
			set
			{
			}
		}

		public bool isDownloadComplete => false;

		private static IntPtr Create([UnityMarshalAs(NativeType.ScriptingObjectPtr)] DownloadHandlerAssetBundle obj, string url, uint crc)
		{
			return (IntPtr)0;
		}

		private static IntPtr CreateCached([UnityMarshalAs(NativeType.ScriptingObjectPtr)] DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc)
		{
			return (IntPtr)0;
		}

		private void InternalCreateAssetBundle(string url, uint crc)
		{
		}

		private void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc)
		{
		}

		public DownloadHandlerAssetBundle(string url, uint crc)
		{
		}

		public DownloadHandlerAssetBundle(string url, CachedAssetBundle cachedBundle, uint crc)
		{
		}

		protected override byte[] GetData()
		{
			return null;
		}

		protected override string GetText()
		{
			return null;
		}

		private static IntPtr Create_Injected(DownloadHandlerAssetBundle obj, ref ManagedSpanWrapper url, uint crc)
		{
			return (IntPtr)0;
		}

		private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, ref ManagedSpanWrapper url, ref ManagedSpanWrapper name, [In] ref Hash128 hash, uint crc)
		{
			return (IntPtr)0;
		}

		private static IntPtr get_assetBundle_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static bool get_autoLoadAssetBundle_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_autoLoadAssetBundle_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_isDownloadComplete_Injected(IntPtr _unity_self)
		{
			return false;
		}
	}
}
