using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	[NativeHeader("VFXScriptingClasses.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
	public class VisualEffectAsset : VisualEffectObject
	{
		public static readonly int PlayEventID;

		public static readonly int StopEventID;
	}
}
