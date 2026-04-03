using System;
using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	public struct AnimationJobCache : IDisposable
	{
		private NativeArray<float> m_Data;

		internal AnimationJobCache(float[] data)
		{
			m_Data = default(NativeArray<float>);
		}

		public void Dispose()
		{
		}

		public float GetRaw(CacheIndex index, int offset = 0)
		{
			return 0f;
		}

		public void SetRaw(float val, CacheIndex index, int offset = 0)
		{
		}

		public T Get<T>(CacheIndex index, int offset = 0) where T : struct
		{
			return default(T);
		}

		public void Set<T>(T val, CacheIndex index, int offset = 0) where T : struct
		{
		}

		public void SetArray<T>(T[] v, CacheIndex index, int offset = 0) where T : struct
		{
		}
	}
}
