using System;
using UnityEngine.Internal;

namespace Unity.Hierarchy
{
	public readonly struct HierarchyPropertyUnmanaged<T> : IEquatable<HierarchyPropertyUnmanaged<T>>, IHierarchyProperty<T> where T : struct
	{
		private readonly Hierarchy m_Hierarchy;

		internal readonly HierarchyPropertyId m_Property;

		internal HierarchyPropertyUnmanaged(Hierarchy hierarchy, in HierarchyPropertyId property)
		{
			m_Hierarchy = null;
			m_Property = default(HierarchyPropertyId);
		}

		public void SetValue(in HierarchyNode node, T value)
		{
		}

		public T GetValue(in HierarchyNode node)
		{
			return default(T);
		}

		[ExcludeFromDocs]
		public bool Equals(HierarchyPropertyUnmanaged<T> other)
		{
			return false;
		}

		[ExcludeFromDocs]
		public override string ToString()
		{
			return null;
		}

		[ExcludeFromDocs]
		public override bool Equals(object obj)
		{
			return false;
		}

		[ExcludeFromDocs]
		public override int GetHashCode()
		{
			return 0;
		}

		T IHierarchyProperty<T>.GetValue(in HierarchyNode node)
		{
			return default(T);
		}

		void IHierarchyProperty<T>.SetValue(in HierarchyNode node, T value)
		{
		}
	}
}
