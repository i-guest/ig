using System.Runtime.InteropServices;

namespace UnityEngine.Bindings
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[VisibleToOtherModules]
	internal ref struct OutStringMarshaller
	{
		public static string GetStringAndDispose(ManagedSpanWrapper managedSpan)
		{
			return null;
		}
	}
}
