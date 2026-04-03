using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering
{
	internal struct SmallEntityIdArray : IDisposable
	{
		private FixedList32Bytes<EntityId> m_FixedArray;

		private UnsafeList<EntityId> m_List;

		private readonly bool m_IsEmbedded;

		public readonly int Length;

		public bool Valid { get; private set; }

		public EntityId this[int index]
		{
			get
			{
				return default(EntityId);
			}
			set
			{
			}
		}

		public SmallEntityIdArray(int length, Allocator allocator)
		{
			m_FixedArray = default(FixedList32Bytes<EntityId>);
			m_List = default(UnsafeList<EntityId>);
			m_IsEmbedded = false;
			Valid = false;
			Length = 0;
		}

		public void Dispose()
		{
		}
	}
}
