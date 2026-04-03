using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	internal static class StringMarshaller
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryMarshalEmptyOrNullString(string s, ref ManagedSpanWrapper managedSpanWrapper)
		{
			return false;
		}
	}
}
