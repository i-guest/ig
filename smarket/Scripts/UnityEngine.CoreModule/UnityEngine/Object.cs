using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode(GenerateProxy = true)]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
	[NativeHeader("Runtime/GameCode/CloneObject.h")]
	public class Object
	{
		[VisibleToOtherModules]
		internal static class MarshalledUnityObject
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static IntPtr Marshal<T>(T obj) where T : Object
			{
				return (IntPtr)0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static IntPtr MarshalNotNull<T>(T obj) where T : Object
			{
				return (IntPtr)0;
			}

			public static void TryThrowEditorNullExceptionObject(Object unityObj, string paramterName)
			{
			}
		}

		private const int kInstanceID_None = 0;

		private IntPtr m_CachedPtr;

		internal static readonly int OffsetOfInstanceIDInCPlusPlusObject;

		private const string objectIsNullMessage = "The Object you want to instantiate is null.";

		private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HideFlags hideFlags
		{
			get
			{
				return default(HideFlags);
			}
			set
			{
			}
		}

		public EntityId GetEntityId()
		{
			return default(EntityId);
		}

		public int GetInstanceID()
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public static implicit operator bool([NotNullWhen(true)][MaybeNullWhen(false)] Object exists)
		{
			return false;
		}

		private static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			return false;
		}

		private void EnsureRunningOnMainThread()
		{
		}

		private static bool IsNativeObjectAlive(Object o)
		{
			return false;
		}

		private IntPtr GetCachedPtr()
		{
			return (IntPtr)0;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Transform parent) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Transform parent, Vector3 position, Quaternion rotation) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Vector3 position, Quaternion rotation) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent, Vector3 position, Quaternion rotation) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent, Vector3 position, Quaternion rotation, CancellationToken cancellationToken) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations, CancellationToken cancellationToken) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, InstantiateParameters parameters, CancellationToken cancellationToken = default(CancellationToken)) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, InstantiateParameters parameters, CancellationToken cancellationToken = default(CancellationToken)) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Vector3 position, Quaternion rotation, InstantiateParameters parameters, CancellationToken cancellationToken = default(CancellationToken)) where T : Object
		{
			return null;
		}

		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Vector3 position, Quaternion rotation, InstantiateParameters parameters, CancellationToken cancellationToken = default(CancellationToken)) where T : Object
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations, InstantiateParameters parameters, CancellationToken cancellationToken = default(CancellationToken)) where T : Object
		{
			return null;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original)
		{
			return null;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Scene scene)
		{
			return null;
		}

		public static T Instantiate<T>(T original, InstantiateParameters parameters) where T : Object
		{
			return null;
		}

		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, InstantiateParameters parameters) where T : Object
		{
			return null;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Transform parent)
		{
			return null;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace)
		{
			return null;
		}

		public static T Instantiate<T>(T original) where T : Object
		{
			return null;
		}

		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			return null;
		}

		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object
		{
			return null;
		}

		public static T Instantiate<T>(T original, Transform parent) where T : Object
		{
			return null;
		}

		public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object
		{
			return null;
		}

		[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = true, ThrowsException = true)]
		public static void Destroy(Object obj, [DefaultValue("0.0F")] float t)
		{
		}

		[ExcludeFromDocs]
		public static void Destroy(Object obj)
		{
		}

		[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = true, ThrowsException = true)]
		public static void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets)
		{
		}

		[ExcludeFromDocs]
		public static void DestroyImmediate(Object obj)
		{
		}

		[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID, but if you do not need this using FindObjectSortMode.None is considerably faster.", false)]
		public static Object[] FindObjectsOfType(Type type)
		{
			return null;
		}

		[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", false)]
		public static Object[] FindObjectsOfType(Type type, bool includeInactive)
		{
			return null;
		}

		public static Object[] FindObjectsByType(Type type, FindObjectsSortMode sortMode)
		{
			return null;
		}

		[FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		public static Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode)
		{
			return null;
		}

		[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = true)]
		public static void DontDestroyOnLoad([NotNull] Object target)
		{
		}

		[Obsolete("use Object.Destroy instead.")]
		public static void DestroyObject(Object obj, [DefaultValue("0.0F")] float t)
		{
		}

		[ExcludeFromDocs]
		[Obsolete("use Object.Destroy instead.")]
		public static void DestroyObject(Object obj)
		{
		}

		[Obsolete("Object.FindSceneObjectsOfType has been deprecated, Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindSceneObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", false)]
		public static Object[] FindSceneObjectsOfType(Type type)
		{
			return null;
		}

		[Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
		[FreeFunction("UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets")]
		public static Object[] FindObjectsOfTypeIncludingAssets(Type type)
		{
			return null;
		}

		[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", false)]
		public static T[] FindObjectsOfType<T>() where T : Object
		{
			return null;
		}

		public static T[] FindObjectsByType<T>(FindObjectsSortMode sortMode) where T : Object
		{
			return null;
		}

		[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", false)]
		public static T[] FindObjectsOfType<T>(bool includeInactive) where T : Object
		{
			return null;
		}

		public static T[] FindObjectsByType<T>(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) where T : Object
		{
			return null;
		}

		[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", false)]
		public static T FindObjectOfType<T>() where T : Object
		{
			return null;
		}

		[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", false)]
		public static T FindObjectOfType<T>(bool includeInactive) where T : Object
		{
			return null;
		}

		public static T FindFirstObjectByType<T>() where T : Object
		{
			return null;
		}

		public static T FindAnyObjectByType<T>() where T : Object
		{
			return null;
		}

		public static T FindFirstObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
		{
			return null;
		}

		public static T FindAnyObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
		{
			return null;
		}

		[Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return null;
		}

		private static void CheckNullArgument(object arg, string message)
		{
		}

		[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", false)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public static Object FindObjectOfType(Type type)
		{
			return null;
		}

		public static Object FindFirstObjectByType(Type type)
		{
			return null;
		}

		public static Object FindAnyObjectByType(Type type)
		{
			return null;
		}

		[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", false)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public static Object FindObjectOfType(Type type, bool includeInactive)
		{
			return null;
		}

		public static Object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive)
		{
			return null;
		}

		public static Object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(Object x, Object y)
		{
			return false;
		}

		public static bool operator !=(Object x, Object y)
		{
			return false;
		}

		[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = true, IsThreadSafe = true)]
		private static int GetOffsetOfInstanceIDInCPlusPlusObject()
		{
			return 0;
		}

		[NativeMethod(Name = "CurrentThreadIsMainThread", IsFreeFunction = true, IsThreadSafe = true)]
		private static bool CurrentThreadIsMainThread()
		{
			return false;
		}

		[NativeMethod(Name = "CloneObject", IsFreeFunction = true, ThrowsException = true)]
		private static Object Internal_CloneSingle([NotNull] Object data)
		{
			return null;
		}

		[FreeFunction("CloneObjectToScene")]
		private static Object Internal_CloneSingleWithScene([NotNull] Object data, Scene scene)
		{
			return null;
		}

		[FreeFunction("CloneObjectWithParams")]
		private static Object Internal_CloneSingleWithParams([NotNull] Object data, InstantiateParameters parameters)
		{
			return null;
		}

		[FreeFunction("InstantiateObjectWithParams")]
		private static Object Internal_InstantiateSingleWithParams([NotNull] Object data, Vector3 position, Quaternion rotation, InstantiateParameters parameters)
		{
			return null;
		}

		[FreeFunction("CloneObject")]
		private static Object Internal_CloneSingleWithParent([NotNull] Object data, [NotNull] Transform parent, bool worldPositionStays)
		{
			return null;
		}

		[FreeFunction("InstantiateAsyncObjects")]
		private static IntPtr Internal_InstantiateAsyncWithParams([NotNull] Object original, int count, InstantiateParameters parameters, IntPtr positions, int positionsCount, IntPtr rotations, int rotationsCount)
		{
			return (IntPtr)0;
		}

		[FreeFunction("InstantiateObject")]
		private static Object Internal_InstantiateSingle([NotNull] Object data, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[FreeFunction("InstantiateObject")]
		private static Object Internal_InstantiateSingleWithParent([NotNull] Object data, [NotNull] Transform parent, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[FreeFunction("UnityEngineObjectBindings::ToString")]
		private static string ToString(Object obj)
		{
			return null;
		}

		[FreeFunction("UnityEngineObjectBindings::GetName", HasExplicitThis = true)]
		private string GetName()
		{
			return null;
		}

		[FreeFunction("UnityEngineObjectBindings::IsPersistent")]
		internal static bool IsPersistent([NotNull] Object obj)
		{
			return false;
		}

		[FreeFunction("UnityEngineObjectBindings::SetName", HasExplicitThis = true)]
		private void SetName(string name)
		{
		}

		[NativeMethod(Name = "UnityEngineObjectBindings::DoesObjectWithInstanceIDExist", IsFreeFunction = true, IsThreadSafe = true)]
		internal static bool DoesObjectWithInstanceIDExist(EntityId instanceID)
		{
			return false;
		}

		[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
		[VisibleToOtherModules]
		internal static Object FindObjectFromInstanceID(EntityId instanceID)
		{
			return null;
		}

		[FreeFunction("UnityEngineObjectBindings::GetPtrFromInstanceID")]
		private static IntPtr GetPtrFromInstanceID(EntityId instanceID, Type objectType, out bool isMonoBehaviour)
		{
			isMonoBehaviour = default(bool);
			return (IntPtr)0;
		}

		[VisibleToOtherModules]
		[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
		internal static Object ForceLoadFromInstanceID(EntityId instanceID)
		{
			return null;
		}

		[FreeFunction("UnityEngineObjectBindings::MarkObjectDirty", HasExplicitThis = true)]
		internal void MarkDirty()
		{
		}

		private static void Destroy_Injected(IntPtr obj, [DefaultValue("0.0F")] float t)
		{
		}

		private static void DestroyImmediate_Injected(IntPtr obj, [DefaultValue("false")] bool allowDestroyingAssets)
		{
		}

		private static void DontDestroyOnLoad_Injected(IntPtr target)
		{
		}

		private static HideFlags get_hideFlags_Injected(IntPtr _unity_self)
		{
			return default(HideFlags);
		}

		private static void set_hideFlags_Injected(IntPtr _unity_self, HideFlags value)
		{
		}

		private static IntPtr Internal_CloneSingle_Injected(IntPtr data)
		{
			return (IntPtr)0;
		}

		private static IntPtr Internal_CloneSingleWithScene_Injected(IntPtr data, [In] ref Scene scene)
		{
			return (IntPtr)0;
		}

		private static IntPtr Internal_CloneSingleWithParams_Injected(IntPtr data, [In] ref InstantiateParameters parameters)
		{
			return (IntPtr)0;
		}

		private static IntPtr Internal_InstantiateSingleWithParams_Injected(IntPtr data, [In] ref Vector3 position, [In] ref Quaternion rotation, [In] ref InstantiateParameters parameters)
		{
			return (IntPtr)0;
		}

		private static IntPtr Internal_CloneSingleWithParent_Injected(IntPtr data, IntPtr parent, bool worldPositionStays)
		{
			return (IntPtr)0;
		}

		private static IntPtr Internal_InstantiateAsyncWithParams_Injected(IntPtr original, int count, [In] ref InstantiateParameters parameters, IntPtr positions, int positionsCount, IntPtr rotations, int rotationsCount)
		{
			return (IntPtr)0;
		}

		private static IntPtr Internal_InstantiateSingle_Injected(IntPtr data, [In] ref Vector3 pos, [In] ref Quaternion rot)
		{
			return (IntPtr)0;
		}

		private static IntPtr Internal_InstantiateSingleWithParent_Injected(IntPtr data, IntPtr parent, [In] ref Vector3 pos, [In] ref Quaternion rot)
		{
			return (IntPtr)0;
		}

		private static void ToString_Injected(IntPtr obj, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void GetName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static bool IsPersistent_Injected(IntPtr obj)
		{
			return false;
		}

		private static void SetName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
		}

		private static bool DoesObjectWithInstanceIDExist_Injected([In] ref EntityId instanceID)
		{
			return false;
		}

		private static IntPtr FindObjectFromInstanceID_Injected([In] ref EntityId instanceID)
		{
			return (IntPtr)0;
		}

		private static IntPtr GetPtrFromInstanceID_Injected([In] ref EntityId instanceID, Type objectType, out bool isMonoBehaviour)
		{
			isMonoBehaviour = default(bool);
			return (IntPtr)0;
		}

		private static IntPtr ForceLoadFromInstanceID_Injected([In] ref EntityId instanceID)
		{
			return (IntPtr)0;
		}

		private static void MarkDirty_Injected(IntPtr _unity_self)
		{
		}
	}
}
