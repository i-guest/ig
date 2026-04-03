using System.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	internal static class SplitListPool
	{
		internal static readonly ObjectPool<Format.SplitList> s_Pool;

		public static Format.SplitList Get(Format format, List<int> splits)
		{
			return null;
		}

		public static void Release(Format.SplitList toRelease)
		{
		}
	}
}
