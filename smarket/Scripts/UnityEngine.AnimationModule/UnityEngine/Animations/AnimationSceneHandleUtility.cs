using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public static class AnimationSceneHandleUtility
	{
		public static void ReadFloats(AnimationStream stream, NativeArray<PropertySceneHandle> handles, NativeArray<float> buffer)
		{
		}

		internal static int ValidateAndGetArrayCount<T0, T1>(ref AnimationStream stream, NativeArray<T0> handles, NativeArray<T1> buffer) where T0 : struct where T1 : struct
		{
			return 0;
		}

		[NativeMethod(Name = "AnimationHandleUtilityBindings::ReadSceneFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private unsafe static void ReadSceneFloatsInternal(ref AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count)
		{
		}
	}
}
