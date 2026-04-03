using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
	[UsedByNativeCode]
	[ExcludeFromPreset]
	public sealed class GameObject : Object
	{
		public Transform transform
		{
			[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = true)]
			get
			{
				return null;
			}
		}

		public int layer
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool activeSelf
		{
			[NativeMethod(Name = "IsSelfActive")]
			get
			{
				return false;
			}
		}

		public bool activeInHierarchy
		{
			[NativeMethod(Name = "IsActive")]
			get
			{
				return false;
			}
		}

		public string tag
		{
			[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = true)]
			get
			{
				return null;
			}
			[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = true)]
			set
			{
			}
		}

		public Scene scene
		{
			[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = true)]
			get
			{
				return default(Scene);
			}
		}

		public ulong sceneCullingMask
		{
			[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = true)]
			get
			{
				return 0uL;
			}
		}

		public GameObject gameObject => null;

		[FreeFunction("GameObjectBindings::CreatePrimitive")]
		public static GameObject CreatePrimitive(PrimitiveType type)
		{
			return null;
		}

		public T GetComponent<T>()
		{
			return default(T);
		}

		[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponent(Type type)
		{
			return null;
		}

		[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
		internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
		}

		[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = true, ThrowsException = true)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type type, bool includeInactive)
		{
			return null;
		}

		[ExcludeFromDocs]
		public T GetComponentInChildren<T>()
		{
			return default(T);
		}

		public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
		{
			return default(T);
		}

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = true, ThrowsException = true)]
		public Component GetComponentInParent(Type type, bool includeInactive)
		{
			return null;
		}

		[ExcludeFromDocs]
		public T GetComponentInParent<T>()
		{
			return default(T);
		}

		public T GetComponentInParent<T>([DefaultValue("false")] bool includeInactive)
		{
			return default(T);
		}

		[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = true, ThrowsException = true)]
		private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList)
		{
			return null;
		}

		public T[] GetComponents<T>()
		{
			return null;
		}

		public void GetComponents<T>(List<T> results)
		{
		}

		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			return null;
		}

		public void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
		{
		}

		public T[] GetComponentsInChildren<T>()
		{
			return null;
		}

		public void GetComponentsInChildren<T>(List<T> results)
		{
		}

		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
		}

		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			return null;
		}

		public bool TryGetComponent<T>(out T component)
		{
			component = default(T);
			return false;
		}

		public bool TryGetComponent(Type type, out Component component)
		{
			component = null;
			return false;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
		internal Component TryGetComponentInternal(Type type)
		{
			return null;
		}

		[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
		internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
		}

		public static GameObject FindWithTag(string tag)
		{
			return null;
		}

		public void SendMessage(string methodName, SendMessageOptions options)
		{
		}

		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
		}

		[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = true)]
		private Component Internal_AddComponentWithType(Type componentType)
		{
			return null;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component AddComponent(Type componentType)
		{
			return null;
		}

		public T AddComponent<T>() where T : Component
		{
			return null;
		}

		[NativeMethod(Name = "SetSelfActive")]
		public void SetActive(bool value)
		{
		}

		public bool CompareTag(string tag)
		{
			return false;
		}

		[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = true)]
		private bool CompareTag_Internal(string tag)
		{
			return false;
		}

		[FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = true)]
		public static GameObject FindGameObjectWithTag(string tag)
		{
			return null;
		}

		[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = true)]
		public static GameObject[] FindGameObjectsWithTag(string tag)
		{
			return null;
		}

		[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = true)]
		public void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options)
		{
		}

		[ExcludeFromDocs]
		public void SendMessage(string methodName, object value)
		{
		}

		[FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = true)]
		public void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options)
		{
		}

		public GameObject(string name)
		{
		}

		public GameObject()
		{
		}

		public GameObject(string name, params Type[] components)
		{
		}

		[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
		private static void Internal_CreateGameObject([Writable] GameObject self, string name)
		{
		}

		[FreeFunction(Name = "GameObjectBindings::Find")]
		public static GameObject Find(string name)
		{
			return null;
		}

		private static IntPtr CreatePrimitive_Injected(PrimitiveType type)
		{
			return (IntPtr)0;
		}

		private static IntPtr GetComponent_Injected(IntPtr _unity_self, Type type)
		{
			return (IntPtr)0;
		}

		private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue)
		{
		}

		private static IntPtr GetComponentInChildren_Injected(IntPtr _unity_self, Type type, bool includeInactive)
		{
			return (IntPtr)0;
		}

		private static IntPtr GetComponentInParent_Injected(IntPtr _unity_self, Type type, bool includeInactive)
		{
			return (IntPtr)0;
		}

		private static Array GetComponentsInternal_Injected(IntPtr _unity_self, Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList)
		{
			return null;
		}

		private static IntPtr TryGetComponentInternal_Injected(IntPtr _unity_self, Type type)
		{
			return (IntPtr)0;
		}

		private static void TryGetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue)
		{
		}

		private static IntPtr Internal_AddComponentWithType_Injected(IntPtr _unity_self, Type componentType)
		{
			return (IntPtr)0;
		}

		private static IntPtr get_transform_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static int get_layer_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_layer_Injected(IntPtr _unity_self, int value)
		{
		}

		private static void SetActive_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_activeSelf_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_activeInHierarchy_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void get_tag_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void set_tag_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}

		private static bool CompareTag_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper tag)
		{
			return false;
		}

		private static IntPtr FindGameObjectWithTag_Injected(ref ManagedSpanWrapper tag)
		{
			return (IntPtr)0;
		}

		private static GameObject[] FindGameObjectsWithTag_Injected(ref ManagedSpanWrapper tag)
		{
			return null;
		}

		private static void SendMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options)
		{
		}

		private static void BroadcastMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options)
		{
		}

		private static void Internal_CreateGameObject_Injected([Writable] GameObject self, ref ManagedSpanWrapper name)
		{
		}

		private static IntPtr Find_Injected(ref ManagedSpanWrapper name)
		{
			return (IntPtr)0;
		}

		private static void get_scene_Injected(IntPtr _unity_self, out Scene ret)
		{
			ret = default(Scene);
		}

		private static ulong get_sceneCullingMask_Injected(IntPtr _unity_self)
		{
			return 0uL;
		}
	}
}
