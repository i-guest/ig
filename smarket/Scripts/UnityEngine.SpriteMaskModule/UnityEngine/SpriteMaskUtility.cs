using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[StaticAccessor("SpriteUtilityBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/SpriteMask/Public/ScriptBindings/SpriteMask.bindings.h")]
	internal static class SpriteMaskUtility
	{
		internal static bool HasSpriteMaskInLayerRange(SortingLayerRange range)
		{
			return false;
		}

		private static bool HasSpriteMaskInLayerRange_Injected([In] ref SortingLayerRange range)
		{
			return false;
		}
	}
}
