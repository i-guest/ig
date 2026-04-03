using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Utilities/PropertyName.h")]
	internal class PropertyNameUtils
	{
		[FreeFunction("PropertyNameFromStringICall", IsThreadSafe = true)]
		public static PropertyName PropertyNameFromString(string name)
		{
			return default(PropertyName);
		}

		private static void PropertyNameFromString_Injected(ref ManagedSpanWrapper name, out PropertyName ret)
		{
			ret = default(PropertyName);
		}
	}
}
