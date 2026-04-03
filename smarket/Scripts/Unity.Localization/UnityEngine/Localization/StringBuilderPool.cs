using System.Text;
using UnityEngine.Pool;

namespace UnityEngine.Localization
{
	internal static class StringBuilderPool
	{
		internal static readonly ObjectPool<StringBuilder> s_Pool;

		public static StringBuilder Get()
		{
			return null;
		}

		public static PooledObject<StringBuilder> Get(out StringBuilder value)
		{
			value = null;
			return default(PooledObject<StringBuilder>);
		}

		public static void Release(StringBuilder toRelease)
		{
		}
	}
}
