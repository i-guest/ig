using System;
using System.Collections.Generic;
using UnityEngine.Pool;

namespace UnityEngine.Rendering.RenderGraphModule
{
	public sealed class RenderGraphObjectPool
	{
		private class SharedObjectPoolBase
		{
			public virtual void Clear()
			{
			}
		}

		private class SharedObjectPool<T> : SharedObjectPoolBase where T : class, new()
		{
			private static readonly UnityEngine.Pool.ObjectPool<T> s_Pool;

			private static UnityEngine.Pool.ObjectPool<T> AllocatePool()
			{
				return null;
			}

			public override void Clear()
			{
			}

			public static T Get()
			{
				return null;
			}

			public static void Release(T toRelease)
			{
			}
		}

		private static DynamicArray<SharedObjectPoolBase> s_AllocatedPools;

		private Dictionary<(Type, int), Stack<object>> m_ArrayPool;

		private List<(object, (Type, int))> m_AllocatedArrays;

		private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

		internal RenderGraphObjectPool()
		{
		}

		public T[] GetTempArray<T>(int size)
		{
			return null;
		}

		public MaterialPropertyBlock GetTempMaterialPropertyBlock()
		{
			return null;
		}

		internal void ReleaseAllTempAlloc()
		{
		}

		internal bool IsEmpty()
		{
			return false;
		}

		internal T Get<T>() where T : class, new()
		{
			return null;
		}

		internal void Release<T>(T value) where T : class, new()
		{
		}

		internal void Cleanup()
		{
		}
	}
}
