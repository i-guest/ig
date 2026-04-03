using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public class SceneProvider : ISceneProvider2, ISceneProvider
	{
		private class SceneOp : AsyncOperationBase<SceneInstance>, IUpdateReceiver
		{
			private bool m_ActivateOnLoad;

			private SceneInstance m_Inst;

			private IResourceLocation m_Location;

			private LoadSceneParameters m_LoadSceneParameters;

			private SceneReleaseMode m_ReleaseMode;

			private int m_Priority;

			private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

			private ResourceManager m_ResourceManager;

			private ISceneProvider2 m_provider;

			protected override string DebugName => null;

			protected override float Progress => 0f;

			public SceneOp(ResourceManager rm, ISceneProvider2 provider)
			{
			}

			internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
			{
				return default(DownloadStatus);
			}

			public void Init(IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
			{
			}

			public void Init(IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			public override void GetDependencies(List<AsyncOperationHandle> deps)
			{
			}

			protected override void Execute()
			{
			}

			internal SceneInstance InternalLoadScene(IResourceLocation location, bool loadingFromBundle, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority)
			{
				return default(SceneInstance);
			}

			private AsyncOperation InternalLoad(string path, bool loadingFromBundle, LoadSceneParameters loadSceneParameters)
			{
				return null;
			}

			protected override void Destroy()
			{
			}

			void IUpdateReceiver.Update(float unscaledDeltaTime)
			{
			}
		}

		private class UnloadSceneOp : AsyncOperationBase<SceneInstance>
		{
			private SceneInstance m_Instance;

			private AsyncOperationHandle<SceneInstance> m_sceneLoadHandle;

			private UnloadSceneOptions m_UnloadOptions;

			protected override float Progress => 0f;

			public void Init(AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions options)
			{
			}

			protected override void Execute()
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			private void UnloadSceneCompleted(AsyncOperation obj)
			{
			}
		}

		public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad, int priority)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		AsyncOperationHandle<SceneInstance> ISceneProvider2.ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}
	}
}
