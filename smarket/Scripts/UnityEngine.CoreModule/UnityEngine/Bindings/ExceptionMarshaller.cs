using System;
using UnityEngine.Scripting;

namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	internal static class ExceptionMarshaller
	{
		[ThreadStatic]
		private static Exception s_pendingException;

		[RequiredByNativeCode]
		private static void SetPendingException(Exception ex)
		{
		}
	}
}
