using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	internal static class SceneManagerAPIInternal
	{
		public static int GetNumScenesInBuildSettings()
		{
			return 0;
		}

		[NativeThrows]
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			return default(Scene);
		}

		[NativeThrows]
		public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			return null;
		}

		[NativeThrows]
		public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			outSuccess = default(bool);
			return null;
		}

		private static void GetSceneByBuildIndex_Injected(int buildIndex, out Scene ret)
		{
			ret = default(Scene);
		}

		private static IntPtr LoadSceneAsyncNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, [In] ref LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			return (IntPtr)0;
		}

		private static IntPtr UnloadSceneNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			outSuccess = default(bool);
			return (IntPtr)0;
		}
	}
}
