using System.Collections.Generic;

namespace UnityEngine.Animations.Rigging
{
	public class AnimationJobCacheBuilder
	{
		private List<float> m_Data;

		public CacheIndex Add(float v)
		{
			return default(CacheIndex);
		}

		public CacheIndex Add(Vector2 v)
		{
			return default(CacheIndex);
		}

		public CacheIndex Add(Vector3 v)
		{
			return default(CacheIndex);
		}

		public CacheIndex Add(Vector4 v)
		{
			return default(CacheIndex);
		}

		public CacheIndex Add(Quaternion v)
		{
			return default(CacheIndex);
		}

		public CacheIndex Add(AffineTransform tx)
		{
			return default(CacheIndex);
		}

		public CacheIndex AllocateChunk(int size)
		{
			return default(CacheIndex);
		}

		public void SetValue(CacheIndex index, int offset, float value)
		{
		}

		public AnimationJobCache Build()
		{
			return default(AnimationJobCache);
		}
	}
}
