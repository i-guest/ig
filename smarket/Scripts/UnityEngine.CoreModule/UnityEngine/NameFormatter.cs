using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/NameFormatter/NameFormatter.h")]
	[VisibleToOtherModules]
	internal sealed class NameFormatter
	{
		[FreeFunction]
		public static string FormatVariableName(string name)
		{
			return null;
		}

		private static void FormatVariableName_Injected(ref ManagedSpanWrapper name, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}
	}
}
