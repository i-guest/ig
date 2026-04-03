using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	[NativeHeader("AssetBundleScriptingClasses.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
	[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
	[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
	[ExcludeFromPreset]
	public class AssetBundle : Object
	{
		private AssetBundle()
		{
		}

		[FreeFunction("GetAllAssetBundles")]
		internal static AssetBundle[] GetAllLoadedAssetBundles_Native()
		{
			return null;
		}

		public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles()
		{
			return null;
		}

		[FreeFunction("LoadFromFileAsync")]
		internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset)
		{
			return null;
		}

		public static AssetBundleCreateRequest LoadFromFileAsync(string path)
		{
			return null;
		}

		public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc)
		{
			return null;
		}

		public T LoadAsset<T>(string name)
		{
			return default(T);
		}

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		public Object LoadAsset(string name, Type type)
		{
			return null;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[NativeMethod("LoadAsset_Internal")]
		[NativeThrows]
		private Object LoadAsset_Internal(string name, Type type)
		{
			return null;
		}

		public AssetBundleRequest LoadAssetAsync(string name, Type type)
		{
			return null;
		}

		public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type)
		{
			return null;
		}

		public AssetBundleRequest LoadAllAssetsAsync()
		{
			return null;
		}

		public AssetBundleRequest LoadAllAssetsAsync<T>()
		{
			return null;
		}

		public AssetBundleRequest LoadAllAssetsAsync(Type type)
		{
			return null;
		}

		[NativeMethod("LoadAssetAsync_Internal")]
		[NativeThrows]
		private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type)
		{
			return null;
		}

		[NativeMethod("Unload")]
		[NativeThrows]
		public void Unload(bool unloadAllLoadedObjects)
		{
		}

		[NativeThrows]
		[NativeMethod("UnloadAsync")]
		public AssetBundleUnloadOperation UnloadAsync(bool unloadAllLoadedObjects)
		{
			return null;
		}

		[NativeThrows]
		[NativeMethod("LoadAssetWithSubAssetsAsync_Internal")]
		private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type)
		{
			return null;
		}

		private static IntPtr LoadFromFileAsync_Internal_Injected(ref ManagedSpanWrapper path, uint crc, ulong offset)
		{
			return (IntPtr)0;
		}

		private static IntPtr LoadAsset_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, Type type)
		{
			return (IntPtr)0;
		}

		private static IntPtr LoadAssetAsync_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, Type type)
		{
			return (IntPtr)0;
		}

		private static void Unload_Injected(IntPtr _unity_self, bool unloadAllLoadedObjects)
		{
		}

		private static IntPtr UnloadAsync_Injected(IntPtr _unity_self, bool unloadAllLoadedObjects)
		{
			return (IntPtr)0;
		}

		private static IntPtr LoadAssetWithSubAssetsAsync_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, Type type)
		{
			return (IntPtr)0;
		}
	}
}
