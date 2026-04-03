using System;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement
{
	public class ResourceManager : IDisposable
	{
		public enum DiagnosticEventType
		{
			AsyncOperationFail = 0,
			AsyncOperationCreate = 1,
			AsyncOperationPercentComplete = 2,
			AsyncOperationComplete = 3,
			AsyncOperationReferenceCount = 4,
			AsyncOperationDestroy = 5
		}

		private struct DeferredCallbackRegisterRequest
		{
			internal IAsyncOperation operation;

			internal bool incrementRefCount;
		}

		private class CompletedOperation<TObject> : AsyncOperationBase<TObject>
		{
			private bool m_Success;

			private Exception m_Exception;

			private bool m_ReleaseDependenciesOnFailure;

			protected override string DebugName => null;

			public void Init(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure = true)
			{
			}

			public void Init(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true)
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			protected override void Execute()
			{
			}
		}

		internal class InstanceOperation : AsyncOperationBase<GameObject>
		{
			private AsyncOperationHandle<GameObject> m_dependency;

			private InstantiationParameters m_instantiationParams;

			private IInstanceProvider m_instanceProvider;

			private GameObject m_instance;

			private Scene m_scene;

			protected override string DebugName => null;

			protected override float Progress => 0f;

			public void Init(ResourceManager rm, IInstanceProvider instanceProvider, InstantiationParameters instantiationParams, AsyncOperationHandle<GameObject> dependency)
			{
			}

			internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
			{
				return default(DownloadStatus);
			}

			public override void GetDependencies(List<AsyncOperationHandle> deps)
			{
			}

			public Scene InstanceScene()
			{
				return default(Scene);
			}

			protected override void Destroy()
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			protected override void Execute()
			{
			}
		}

		internal bool CallbackHooksEnabled;

		private ListWithEvents<IResourceProvider> m_ResourceProviders;

		private IAllocationStrategy m_allocator;

		internal ListWithEvents<IUpdateReceiver> m_UpdateReceivers;

		private List<IUpdateReceiver> m_UpdateReceiversToRemove;

		private bool m_UpdatingReceivers;

		private bool m_InsideUpdateMethod;

		internal Dictionary<int, IResourceProvider> m_providerMap;

		private Dictionary<IOperationCacheKey, IAsyncOperation> m_AssetOperationCache;

		private HashSet<InstanceOperation> m_TrackedInstanceOperations;

		internal DelegateList<float> m_UpdateCallbacks;

		private List<IAsyncOperation> m_DeferredCompleteCallbacks;

		private bool m_InsideExecuteDeferredCallbacksMethod;

		private List<DeferredCallbackRegisterRequest> m_DeferredCallbacksToRegister;

		private Action<IAsyncOperation> m_ReleaseOpNonCached;

		private Action<IAsyncOperation> m_ReleaseOpCached;

		private Action<IAsyncOperation> m_ReleaseInstanceOp;

		private static int s_GroupOperationTypeHash;

		private static int s_InstanceOperationTypeHash;

		private bool m_RegisteredForCallbacks;

		private Dictionary<Type, Type> m_ProviderOperationTypeCache;

		public static Action<AsyncOperationHandle, Exception> ExceptionHandler { get; set; }

		public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }

		public Action<UnityWebRequest> WebRequestOverride { get; set; }

		internal int OperationCacheCount => 0;

		internal int InstanceOperationCount => 0;

		internal int DeferredCompleteCallbacksCount => 0;

		internal int DeferredCallbackCount => 0;

		public IAllocationStrategy Allocator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<IResourceProvider> ResourceProviders => null;

		public CertificateHandler CertificateHandlerInstance { get; set; }

		public string TransformInternalId(IResourceLocation location)
		{
			return null;
		}

		public void AddUpdateReceiver(IUpdateReceiver receiver)
		{
		}

		public void RemoveUpdateReciever(IUpdateReceiver receiver)
		{
		}

		public ResourceManager(IAllocationStrategy alloc = null)
		{
		}

		private void OnObjectAdded(object obj)
		{
		}

		private void OnObjectRemoved(object obj)
		{
		}

		internal void RegisterForCallbacks()
		{
		}

		public IResourceProvider GetResourceProvider(Type t, IResourceLocation location)
		{
			return null;
		}

		private Type GetDefaultTypeForLocation(IResourceLocation loc)
		{
			return null;
		}

		private int CalculateLocationsHash(IList<IResourceLocation> locations, Type t = null)
		{
			return 0;
		}

		private AsyncOperationHandle ProvideResource(IResourceLocation location, Type desiredType = null, bool releaseDependenciesOnFailure = true)
		{
			return default(AsyncOperationHandle);
		}

		internal IAsyncOperation GetOperationFromCache(IResourceLocation location, Type desiredType)
		{
			return null;
		}

		internal IOperationCacheKey CreateCacheKeyForLocation(IResourceProvider provider, IResourceLocation location, Type desiredType = null)
		{
			return null;
		}

		public AsyncOperationHandle<TObject> ProvideResource<TObject>(IResourceLocation location)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public AsyncOperationHandle<TObject> StartOperation<TObject>(AsyncOperationBase<TObject> operation, AsyncOperationHandle dependency)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		internal AsyncOperationHandle StartOperation(IAsyncOperation operation, AsyncOperationHandle dependency)
		{
			return default(AsyncOperationHandle);
		}

		private void OnInstanceOperationDestroy(IAsyncOperation o)
		{
		}

		private void OnOperationDestroyNonCached(IAsyncOperation o)
		{
		}

		private void OnOperationDestroyCached(IAsyncOperation o)
		{
		}

		internal T CreateOperation<T>(Type actualType, int typeHash, IOperationCacheKey cacheKey, Action<IAsyncOperation> onDestroyAction)
		{
			return default(T);
		}

		internal void AddOperationToCache(IOperationCacheKey key, IAsyncOperation operation)
		{
		}

		internal bool RemoveOperationFromCache(IOperationCacheKey key)
		{
			return false;
		}

		internal bool IsOperationCached(IOperationCacheKey key)
		{
			return false;
		}

		internal int CachedOperationCount()
		{
			return 0;
		}

		internal void ClearOperationCache()
		{
		}

		public AsyncOperationHandle<TObject> CreateCompletedOperation<TObject>(TObject result, string errorMsg)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public AsyncOperationHandle<TObject> CreateCompletedOperationWithException<TObject>(TObject result, Exception exception)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		internal AsyncOperationHandle<TObject> CreateCompletedOperationInternal<TObject>(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public void Release(AsyncOperationHandle handle)
		{
		}

		public AsyncOperationHandle<TObject> Acquire<TObject>(AsyncOperationHandle<TObject> handle)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public void Acquire(AsyncOperationHandle handle)
		{
		}

		private GroupOperation AcquireGroupOpFromCache(IOperationCacheKey key)
		{
			return null;
		}

		public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations)
		{
			return default(AsyncOperationHandle<IList<AsyncOperationHandle>>);
		}

		internal AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations, bool allowFailedDependencies)
		{
			return default(AsyncOperationHandle<IList<AsyncOperationHandle>>);
		}

		public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGenericGroupOperation(List<AsyncOperationHandle> operations, bool releasedCachedOpOnComplete = false)
		{
			return default(AsyncOperationHandle<IList<AsyncOperationHandle>>);
		}

		internal AsyncOperationHandle<IList<AsyncOperationHandle>> ProvideResourceGroupCached(IList<IResourceLocation> locations, int groupHash, Type desiredType, Action<AsyncOperationHandle> callback, bool releaseDependenciesOnFailure = true)
		{
			return default(AsyncOperationHandle<IList<AsyncOperationHandle>>);
		}

		public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, Action<TObject> callback = null)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, bool releaseDependenciesOnFailure, Action<TObject> callback = null)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = true)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = true)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad, int priority)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider sceneProvider, AsyncOperationHandle<SceneInstance> sceneLoadHandle)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<GameObject> ProvideInstance(IInstanceProvider provider, IResourceLocation location, InstantiationParameters instantiateParameters)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public void CleanupSceneInstances(Scene scene)
		{
		}

		private void ExecuteDeferredCallbacks()
		{
		}

		internal void RegisterForDeferredCallback(IAsyncOperation op, bool incrementRefCount = true)
		{
		}

		internal void Update(float unscaledDeltaTime)
		{
		}

		public void Dispose()
		{
		}
	}
}
