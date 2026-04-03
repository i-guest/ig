using System.Reflection;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[HelpURL("AnimatorOverrideController")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	[DefaultMember("Item")]
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
		internal delegate void OnOverrideControllerDirtyCallback();

		internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

		[NativeConditional("UNITY_EDITOR")]
		[RequiredByNativeCode]
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller)
		{
		}
	}
}
