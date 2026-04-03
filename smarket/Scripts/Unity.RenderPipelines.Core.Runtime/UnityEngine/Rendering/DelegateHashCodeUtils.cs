using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	internal static class DelegateHashCodeUtils
	{
		private static readonly Lazy<Dictionary<int, bool>> s_MethodHashCodeToSkipTargetHashMap;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetFuncHashCode(Delegate del)
		{
			return 0;
		}

		internal static int GetTotalCacheCount()
		{
			return 0;
		}

		internal static void ClearCache()
		{
		}
	}
}
