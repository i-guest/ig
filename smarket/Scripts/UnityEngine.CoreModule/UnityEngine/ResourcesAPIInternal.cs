using System;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
	[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
	internal static class ResourcesAPIInternal
	{
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return null;
		}

		[FreeFunction("GetShaderNameRegistry().FindShader")]
		public static Shader FindShaderByName(string name)
		{
			return null;
		}

		[NativeThrows]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[FreeFunction("Resources_Bindings::Load")]
		public static Object Load(string path, [NotNull] Type systemTypeInstance)
		{
			return null;
		}

		[NativeThrows]
		[FreeFunction("Resources_Bindings::LoadAll")]
		public static Object[] LoadAll([NotNull] string path, [NotNull] Type systemTypeInstance)
		{
			return null;
		}

		[FreeFunction("Scripting::UnloadAssetFromScripting")]
		public static void UnloadAsset(Object assetToUnload)
		{
		}

		private static IntPtr FindShaderByName_Injected(ref ManagedSpanWrapper name)
		{
			return (IntPtr)0;
		}

		private static IntPtr Load_Injected(ref ManagedSpanWrapper path, Type systemTypeInstance)
		{
			return (IntPtr)0;
		}

		private static Object[] LoadAll_Injected(ref ManagedSpanWrapper path, Type systemTypeInstance)
		{
			return null;
		}

		private static void UnloadAsset_Injected(IntPtr assetToUnload)
		{
		}
	}
}
