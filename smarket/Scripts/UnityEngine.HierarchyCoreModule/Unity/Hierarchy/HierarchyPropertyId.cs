using System;
using UnityEngine.Bindings;

namespace Unity.Hierarchy
{
	[NativeHeader("Modules/HierarchyCore/Public/HierarchyPropertyId.h")]
	internal readonly struct HierarchyPropertyId : IEquatable<HierarchyPropertyId>
	{
		private static readonly HierarchyPropertyId s_Null;

		private readonly int m_Id;

		public static ref readonly HierarchyPropertyId Null
		{
			get
			{
				throw null;
			}
		}

		public int Id => 0;

		public HierarchyPropertyId()
		{
			m_Id = 0;
		}

		public static bool operator ==(in HierarchyPropertyId lhs, in HierarchyPropertyId rhs)
		{
			return false;
		}

		public bool Equals(HierarchyPropertyId other)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
