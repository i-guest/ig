using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	internal static class ParsingErrorsPool
	{
		internal static readonly ObjectPool<ParsingErrors> s_Pool;

		public static ParsingErrors Get(Format format)
		{
			return null;
		}

		public static void Release(ParsingErrors toRelease)
		{
		}
	}
}
