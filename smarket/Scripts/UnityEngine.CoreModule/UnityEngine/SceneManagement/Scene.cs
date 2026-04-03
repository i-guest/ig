using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	[Serializable]
	[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
	public struct Scene
	{
		[HideInInspector]
		[SerializeField]
		private SceneHandle m_Handle;

		public SceneHandle handle => default(SceneHandle);

		internal string guid => null;

		public string name => null;

		public bool isLoaded => false;

		public int buildIndex => 0;

		public int rootCount => 0;

		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		private static bool IsValidInternal(SceneHandle sceneHandle)
		{
			return false;
		}

		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		private static string GetNameInternal(SceneHandle sceneHandle)
		{
			return null;
		}

		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		private static string GetGUIDInternal(SceneHandle sceneHandle)
		{
			return null;
		}

		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		private static bool GetIsLoadedInternal(SceneHandle sceneHandle)
		{
			return false;
		}

		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		private static int GetBuildIndexInternal(SceneHandle sceneHandle)
		{
			return 0;
		}

		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		private static int GetRootCountInternal(SceneHandle sceneHandle)
		{
			return 0;
		}

		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		private static void GetRootGameObjectsInternal(SceneHandle sceneHandle, object resultRootList)
		{
		}

		public bool IsValid()
		{
			return false;
		}

		public GameObject[] GetRootGameObjects()
		{
			return null;
		}

		public void GetRootGameObjects(List<GameObject> rootGameObjects)
		{
		}

		public static bool operator ==(Scene lhs, Scene rhs)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		private static bool IsValidInternal_Injected([In] ref SceneHandle sceneHandle)
		{
			return false;
		}

		private static void GetNameInternal_Injected([In] ref SceneHandle sceneHandle, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void GetGUIDInternal_Injected([In] ref SceneHandle sceneHandle, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static bool GetIsLoadedInternal_Injected([In] ref SceneHandle sceneHandle)
		{
			return false;
		}

		private static int GetBuildIndexInternal_Injected([In] ref SceneHandle sceneHandle)
		{
			return 0;
		}

		private static int GetRootCountInternal_Injected([In] ref SceneHandle sceneHandle)
		{
			return 0;
		}

		private static void GetRootGameObjectsInternal_Injected([In] ref SceneHandle sceneHandle, object resultRootList)
		{
		}
	}
}
