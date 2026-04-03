using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

namespace UnityEngine.AddressableAssets
{
	public static class Addressables
	{
		public enum MergeMode
		{
			None = 0,
			UseFirst = 0,
			Union = 1,
			Intersection = 2
		}

		internal static bool reinitializeAddressables;

		internal static AddressablesImpl m_AddressablesInstance;

		public const string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath";

		private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";

		public const string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog";

		public static string LibraryPath;

		public static string BuildReportPath;

		private static AddressablesImpl m_Addressables => null;

		public static string Version => null;

		public static ResourceManager ResourceManager => null;

		internal static AddressablesImpl Instance => null;

		public static IInstanceProvider InstanceProvider => null;

		public static Func<IResourceLocation, string> InternalIdTransformFunc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Action<UnityWebRequest> WebRequestOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string StreamingAssetsSubFolder => null;

		public static string BuildPath => null;

		public static string PlayerBuildDataPath => null;

		[Preserve]
		public static string RuntimePath => null;

		public static IEnumerable<IResourceLocator> ResourceLocators => null;

		public static string ResolveInternalId(string id)
		{
			return null;
		}

		[Conditional("ADDRESSABLES_LOG_ALL")]
		internal static void InternalSafeSerializationLog(string msg, LogType logType = LogType.Log)
		{
		}

		[Conditional("ADDRESSABLES_LOG_ALL")]
		internal static void InternalSafeSerializationLogFormat(string format, LogType logType = LogType.Log, params object[] args)
		{
		}

		[Conditional("ADDRESSABLES_LOG_ALL")]
		public static void Log(string msg)
		{
		}

		[Conditional("ADDRESSABLES_LOG_ALL")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		public static void LogWarning(string msg)
		{
		}

		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		public static void LogError(string msg)
		{
		}

		public static void LogException(AsyncOperationHandle op, Exception ex)
		{
		}

		public static void LogException(Exception ex)
		{
		}

		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		public static AsyncOperationHandle<IResourceLocator> InitializeAsync()
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		public static AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix = null)
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix = null)
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, MergeMode mode, Type type = null)
		{
			return default(AsyncOperationHandle<IList<IResourceLocation>>);
		}

		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type = null)
		{
			return default(AsyncOperationHandle<IList<IResourceLocation>>);
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, MergeMode mode)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(string key, Action<TObject> callback = null)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, MergeMode mode, bool releaseDependenciesOnFailure)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(string key, bool releaseDependenciesOnFailure, Action<TObject> callback = null)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public static void Release<TObject>(TObject obj)
		{
		}

		public static void Release<TObject>(AsyncOperationHandle<TObject> handle)
		{
		}

		public static void Release(AsyncOperationHandle handle)
		{
		}

		public static bool ReleaseInstance(GameObject instance)
		{
			return false;
		}

		public static bool ReleaseInstance(AsyncOperationHandle handle)
		{
			return false;
		}

		public static bool ReleaseInstance(AsyncOperationHandle<GameObject> handle)
		{
			return false;
		}

		public static AsyncOperationHandle<long> GetDownloadSizeAsync(object key)
		{
			return default(AsyncOperationHandle<long>);
		}

		public static AsyncOperationHandle<long> GetDownloadSizeAsync(string key)
		{
			return default(AsyncOperationHandle<long>);
		}

		public static AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys)
		{
			return default(AsyncOperationHandle<long>);
		}

		public static AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = false)
		{
			return default(AsyncOperationHandle);
		}

		public static AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = false)
		{
			return default(AsyncOperationHandle);
		}

		public static AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, MergeMode mode, bool autoReleaseHandle = false)
		{
			return default(AsyncOperationHandle);
		}

		public static void ClearDependencyCacheAsync(object key)
		{
		}

		public static void ClearDependencyCacheAsync(IList<IResourceLocation> locations)
		{
		}

		public static void ClearDependencyCacheAsync(IEnumerable keys)
		{
		}

		public static void ClearDependencyCacheAsync(string key)
		{
		}

		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<bool>);
		}

		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<bool>);
		}

		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<bool>);
		}

		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<bool>);
		}

		public static ResourceLocatorInfo GetLocatorInfo(string locatorId)
		{
			return null;
		}

		public static ResourceLocatorInfo GetLocatorInfo(IResourceLocator locator)
		{
			return null;
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100, SceneReleaseMode releaseMode = SceneReleaseMode.ReleaseSceneWhenSceneUnloaded)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode, SceneReleaseMode releaseMode, bool activateOnLoad = true, int priority = 100)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad = true, int priority = 100)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode, SceneReleaseMode releaseMode, bool activateOnLoad = true, int priority = 100)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad = true, int priority = 100)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public static AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<List<string>>);
		}

		public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogs = null, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<List<IResourceLocator>>);
		}

		public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(bool autoCleanBundleCache, IEnumerable<string> catalogs = null, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<List<IResourceLocator>>);
		}

		public static void AddResourceLocator(IResourceLocator locator, string localCatalogHash = null, IResourceLocation remoteCatalogLocation = null)
		{
		}

		public static void RemoveResourceLocator(IResourceLocator locator)
		{
		}

		public static void ClearResourceLocators()
		{
		}

		public static AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogsIds = null)
		{
			return default(AsyncOperationHandle<bool>);
		}

		public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath)
		{
			return null;
		}

		public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation remoteCatalogLocation)
		{
			return null;
		}

		public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath, string remoteHashPath)
		{
			return null;
		}
	}
}
