namespace UnityEngine.Pool
{
	public class GenericPool<T> where T : class, new()
	{
		internal static readonly ObjectPool<T> s_Pool;

		public static T Get()
		{
			return null;
		}

		public static PooledObject<T> Get(out T value)
		{
			value = null;
			return default(PooledObject<T>);
		}

		public static void Release(T toRelease)
		{
		}
	}
}
