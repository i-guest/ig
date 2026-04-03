using System;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public class AssetBundleResource : IAssetBundleResource, IUpdateReceiver
	{
		public enum LoadType
		{
			None = 0,
			Local = 1,
			Web = 2
		}

		internal enum CacheStatus
		{
			Unknown = 0,
			Cached = 1,
			NotCached = 2
		}

		private AssetBundle m_AssetBundle;

		private AsyncOperation m_RequestOperation;

		internal WebRequestQueueOperation m_WebRequestQueueOperation;

		internal ProvideHandle m_ProvideHandle;

		internal AssetBundleRequestOptions m_Options;

		internal CacheStatus cacheStatus;

		[NonSerialized]
		private bool m_RequestCompletedCallbackCalled;

		private int m_Retries;

		private BundleSource m_Source;

		private long m_BytesToDownload;

		private long m_DownloadedBytes;

		private bool m_Completed;

		private AssetBundleUnloadOperation m_UnloadOperation;

		private const int k_WaitForWebRequestMainThreadSleep = 1;

		private string m_TransformedInternalId;

		private AssetBundleRequest m_PreloadRequest;

		private bool m_PreloadCompleted;

		private ulong m_LastDownloadedByteCount;

		private float m_TimeoutTimer;

		private int m_TimeoutOverFrames;

		internal bool m_DownloadOnly;

		private int m_LastFrameCount;

		private float m_TimeSecSinceLastUpdate;

		internal Func<UnityWebRequestResult, bool> m_RequestRetryCallback;

		private bool HasTimedOut => false;

		internal long BytesToDownload => 0L;

		internal bool IsCached()
		{
			return false;
		}

		internal UnityWebRequest CreateWebRequest(IResourceLocation loc)
		{
			return null;
		}

		internal UnityWebRequest CreateWebRequest(string url)
		{
			return null;
		}

		public AssetBundleRequest GetAssetPreloadRequest()
		{
			return null;
		}

		private float PercentComplete()
		{
			return 0f;
		}

		private DownloadStatus GetDownloadStatus()
		{
			return default(DownloadStatus);
		}

		public AssetBundle GetAssetBundle()
		{
			return null;
		}

		private void OnUnloadOperationComplete(AsyncOperation op)
		{
		}

		public void Start(ProvideHandle provideHandle, AssetBundleUnloadOperation unloadOp, Func<UnityWebRequestResult, bool> requestRetryCallback)
		{
		}

		private bool WaitForCompletionHandler()
		{
			return false;
		}

		private void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback)
		{
		}

		public static void GetLoadInfo(ProvideHandle handle, out LoadType loadType, out string path)
		{
			loadType = default(LoadType);
			path = null;
		}

		internal static void GetLoadInfo(IResourceLocation location, ResourceManager resourceManager, out LoadType loadType, out string path)
		{
			loadType = default(LoadType);
			path = null;
		}

		private void BeginOperation()
		{
		}

		private void LoadLocalBundle()
		{
		}

		internal WebRequestQueueOperation EnqueueWebRequest(string internalId)
		{
			return null;
		}

		internal void AddBeginWebRequestHandler(WebRequestQueueOperation webRequestQueueOperation)
		{
		}

		private void BeginWebRequestOperation(AsyncOperation asyncOp)
		{
		}

		public void Update(float unscaledDeltaTime)
		{
		}

		private void LocalRequestOperationCompleted(AsyncOperation op)
		{
		}

		private void CompleteBundleLoad(AssetBundle bundle)
		{
		}

		private void WebRequestOperationCompleted(AsyncOperation op)
		{
		}

		public bool Unload(out AssetBundleUnloadOperation unloadOp)
		{
			unloadOp = null;
			return false;
		}
	}
}
