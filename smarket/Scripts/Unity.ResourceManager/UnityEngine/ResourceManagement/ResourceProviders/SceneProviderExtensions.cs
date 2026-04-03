using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	internal static class SceneProviderExtensions
	{
		public static AsyncOperationHandle<SceneInstance> ReleaseScene(this ISceneProvider provider, ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}
	}
}
