using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.Localization
{
	internal class AddressablesInterface
	{
		private static AddressablesInterface s_Instance;

		public static AddressablesInterface Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static ResourceManager ResourceManager => null;

		public static void Acquire(AsyncOperationHandle handle)
		{
		}

		public static void Release(AsyncOperationHandle handle)
		{
		}

		public static void SafeRelease(AsyncOperationHandle handle)
		{
		}

		public static void ReleaseAndReset<TObject>(ref AsyncOperationHandle<TObject> handle)
		{
		}

		public static AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation(List<AsyncOperationHandle> asyncOperations)
		{
			return default(AsyncOperationHandle<IList<AsyncOperationHandle>>);
		}

		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithLabelsAsync(IEnumerable labels, Addressables.MergeMode mode, Type type = null)
		{
			return default(AsyncOperationHandle<IList<IResourceLocation>>);
		}

		public static AsyncOperationHandle<IList<IResourceLocation>> LoadTableLocationsAsync(string tableName, LocaleIdentifier id, Type type)
		{
			return default(AsyncOperationHandle<IList<IResourceLocation>>);
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsFromLocations<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public static AsyncOperationHandle<TObject> LoadAssetFromGUID<TObject>(string guid) where TObject : class
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public static AsyncOperationHandle<TObject> LoadAssetFromName<TObject>(string name) where TObject : class
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public static AsyncOperationHandle<TObject> LoadTableFromLocation<TObject>(IResourceLocation location) where TObject : class
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsWithLabel<TObject>(string label, Action<TObject> callback) where TObject : class
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		internal virtual void AcquireInternal(AsyncOperationHandle handle)
		{
		}

		internal virtual void ReleaseInternal(AsyncOperationHandle handle)
		{
		}

		internal virtual AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithLabelsAsyncInternal(IEnumerable labels, Addressables.MergeMode mode, Type type = null)
		{
			return default(AsyncOperationHandle<IList<IResourceLocation>>);
		}

		internal virtual AsyncOperationHandle<IList<IResourceLocation>> LoadTableLocationsAsyncInternal(string tableName, LocaleIdentifier id, Type type)
		{
			return default(AsyncOperationHandle<IList<IResourceLocation>>);
		}

		internal virtual AsyncOperationHandle<IList<TObject>> LoadAssetsFromLocationsInternal<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		internal virtual AsyncOperationHandle<TObject> LoadAssetFromGUIDInternal<TObject>(string guid) where TObject : class
		{
			return default(AsyncOperationHandle<TObject>);
		}

		internal virtual AsyncOperationHandle<TObject> LoadAssetFromNameInternal<TObject>(string name) where TObject : class
		{
			return default(AsyncOperationHandle<TObject>);
		}

		internal virtual AsyncOperationHandle<TObject> LoadTableFromLocationInternal<TObject>(IResourceLocation location) where TObject : class
		{
			return default(AsyncOperationHandle<TObject>);
		}

		internal virtual AsyncOperationHandle<IList<TObject>> LoadAssetsWithLabelInternal<TObject>(string label, Action<TObject> callback) where TObject : class
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		internal virtual AsyncOperationHandle<IResourceLocator> InitializeAddressablesAsync()
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}
	}
}
