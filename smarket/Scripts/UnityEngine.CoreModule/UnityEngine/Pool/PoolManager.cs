using System;
using System.Collections.Generic;

namespace UnityEngine.Pool
{
	internal static class PoolManager
	{
		private static readonly List<WeakReference<IPool>> s_WeakPoolReferences;

		public static void Register(IPool pool)
		{
		}
	}
}
