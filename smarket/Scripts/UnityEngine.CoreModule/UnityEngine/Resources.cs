using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
	[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
	public sealed class Resources
	{
		internal static T[] ConvertObjects<T>(Object[] rawObjects) where T : Object
		{
			return null;
		}

		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return null;
		}

		public static T[] FindObjectsOfTypeAll<T>() where T : Object
		{
			return null;
		}

		public static Object Load(string path)
		{
			return null;
		}

		public static T Load<T>(string path) where T : Object
		{
			return null;
		}

		public static Object Load(string path, Type systemTypeInstance)
		{
			return null;
		}

		public static Object[] LoadAll(string path, Type systemTypeInstance)
		{
			return null;
		}

		public static T[] LoadAll<T>(string path) where T : Object
		{
			return null;
		}

		[FreeFunction("GetScriptingBuiltinResource", ThrowsException = true)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public static Object GetBuiltinResource([NotNull] Type type, string path)
		{
			return null;
		}

		public static T GetBuiltinResource<T>(string path) where T : Object
		{
			return null;
		}

		public static void UnloadAsset(Object assetToUnload)
		{
		}

		[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
		public static AsyncOperation UnloadUnusedAssets()
		{
			return null;
		}

		[FreeFunction("Resources_Bindings::InstanceIDToObject")]
		public static Object EntityIdToObject(EntityId entityId)
		{
			return null;
		}

		[FreeFunction("Resources_Bindings::DoesObjectWithInstanceIDExist", IsThreadSafe = true)]
		public static bool EntityIdIsValid(EntityId entityId)
		{
			return false;
		}

		private static IntPtr GetBuiltinResource_Injected(Type type, ref ManagedSpanWrapper path)
		{
			return (IntPtr)0;
		}

		private static IntPtr UnloadUnusedAssets_Injected()
		{
			return (IntPtr)0;
		}

		private static IntPtr EntityIdToObject_Injected([In] ref EntityId entityId)
		{
			return (IntPtr)0;
		}

		private static bool EntityIdIsValid_Injected([In] ref EntityId entityId)
		{
			return false;
		}
	}
}
