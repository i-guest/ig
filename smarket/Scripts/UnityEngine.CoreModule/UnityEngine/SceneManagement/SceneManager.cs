using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	[RequiredByNativeCode]
	public class SceneManager
	{
		internal static bool s_AllowLoadScene;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UnityAction<Scene, Scene> activeSceneChanged;

		public static int sceneCount
		{
			[NativeMethod("GetSceneCount")]
			[StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
			[NativeHeader("Runtime/SceneManager/SceneManager.h")]
			get
			{
				return 0;
			}
		}

		public static int sceneCountInBuildSettings => 0;

		public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event UnityAction<Scene> sceneUnloaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static Scene GetActiveScene()
		{
			return default(Scene);
		}

		[NativeThrows]
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static bool SetActiveScene(Scene scene)
		{
			return false;
		}

		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static Scene GetSceneByName(string name)
		{
			return default(Scene);
		}

		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			return default(Scene);
		}

		[NativeThrows]
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static Scene GetSceneAt(int index)
		{
			return default(Scene);
		}

		[NativeThrows]
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options)
		{
			return null;
		}

		private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			return null;
		}

		private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			outSuccess = default(bool);
			return null;
		}

		[NativeThrows]
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static void MoveGameObjectToScene([NotNull] GameObject go, Scene scene)
		{
		}

		[RequiredByNativeCode]
		internal static AsyncOperation LoadFirstScene_Internal(bool async)
		{
			return null;
		}

		public static void LoadScene(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
		}

		[ExcludeFromDocs]
		public static void LoadScene(string sceneName)
		{
		}

		public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
		{
			return default(Scene);
		}

		[ExcludeFromDocs]
		public static void LoadScene(int sceneBuildIndex)
		{
		}

		public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			return default(Scene);
		}

		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			return null;
		}

		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			return null;
		}

		public static AsyncOperation LoadSceneAsync(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static AsyncOperation LoadSceneAsync(string sceneName)
		{
			return null;
		}

		public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
		{
			return null;
		}

		public static AsyncOperation UnloadSceneAsync(string sceneName)
		{
			return null;
		}

		public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options)
		{
			return null;
		}

		[RequiredByNativeCode]
		private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[RequiredByNativeCode]
		private static void Internal_SceneUnloaded(Scene scene)
		{
		}

		[RequiredByNativeCode]
		private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
		}

		private static void GetActiveScene_Injected(out Scene ret)
		{
			ret = default(Scene);
		}

		private static bool SetActiveScene_Injected([In] ref Scene scene)
		{
			return false;
		}

		private static void GetSceneByName_Injected(ref ManagedSpanWrapper name, out Scene ret)
		{
			ret = default(Scene);
		}

		private static void GetSceneAt_Injected(int index, out Scene ret)
		{
			ret = default(Scene);
		}

		private static IntPtr UnloadSceneAsyncInternal_Injected([In] ref Scene scene, UnloadSceneOptions options)
		{
			return (IntPtr)0;
		}

		private static void MoveGameObjectToScene_Injected(IntPtr go, [In] ref Scene scene)
		{
		}
	}
}
