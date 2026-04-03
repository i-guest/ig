using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/AvatarMask.h")]
	[MovedFrom(true, "UnityEditor.Animations", "UnityEditor", null)]
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	public sealed class AvatarMask : Object
	{
		public int transformCount => 0;

		[FreeFunction("AnimationBindings::CreateAvatarMask")]
		private static void Internal_Create([Writable] AvatarMask self)
		{
		}

		[NativeMethod("GetBodyPart")]
		public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index)
		{
			return false;
		}

		public string GetTransformPath(int index)
		{
			return null;
		}

		private float GetTransformWeight(int index)
		{
			return 0f;
		}

		public bool GetTransformActive(int index)
		{
			return false;
		}

		private static bool GetHumanoidBodyPartActive_Injected(IntPtr _unity_self, AvatarMaskBodyPart index)
		{
			return false;
		}

		private static int get_transformCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void GetTransformPath_Injected(IntPtr _unity_self, int index, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static float GetTransformWeight_Injected(IntPtr _unity_self, int index)
		{
			return 0f;
		}
	}
}
