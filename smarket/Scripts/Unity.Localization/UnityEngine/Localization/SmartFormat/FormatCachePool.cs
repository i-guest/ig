using UnityEngine.Localization.SmartFormat.Core.Formatting;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	internal static class FormatCachePool
	{
		internal static readonly ObjectPool<FormatCache> s_Pool;

		public static FormatCache Get(Format format)
		{
			return null;
		}

		public static PooledObject<FormatCache> Get(Format format, out FormatCache value)
		{
			value = null;
			return default(PooledObject<FormatCache>);
		}

		public static void Release(FormatCache toRelease)
		{
		}
	}
}
