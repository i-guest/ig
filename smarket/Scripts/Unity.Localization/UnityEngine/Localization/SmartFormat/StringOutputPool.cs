using UnityEngine.Localization.SmartFormat.Core.Output;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	internal static class StringOutputPool
	{
		internal static readonly ObjectPool<StringOutput> s_Pool;

		public static StringOutput Get(int capacity)
		{
			return null;
		}

		public static PooledObject<StringOutput> Get(int capacity, out StringOutput value)
		{
			value = null;
			return default(PooledObject<StringOutput>);
		}

		public static void Release(StringOutput toRelease)
		{
		}
	}
}
