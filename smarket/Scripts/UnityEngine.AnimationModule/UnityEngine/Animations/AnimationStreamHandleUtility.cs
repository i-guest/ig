using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	public static class AnimationStreamHandleUtility
	{
		public static void WriteFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<float> buffer, bool useMask)
		{
		}

		public static void ReadFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<float> buffer)
		{
		}

		[NativeMethod(Name = "AnimationHandleUtilityBindings::ReadStreamFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private unsafe static void ReadStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count)
		{
		}

		[NativeMethod(Name = "AnimationHandleUtilityBindings::WriteStreamFloatsInternal", IsFreeFunction = true, HasExplicitThis = false, IsThreadSafe = true)]
		private unsafe static void WriteStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count, bool useMask)
		{
		}
	}
}
