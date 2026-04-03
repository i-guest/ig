using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace Unity.Hierarchy
{
	[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeType.h")]
	public readonly struct HierarchyNodeType : IEquatable<HierarchyNodeType>
	{
		private static readonly HierarchyNodeType s_Null;

		private readonly int m_Id;

		public static ref readonly HierarchyNodeType Null
		{
			get
			{
				throw null;
			}
		}

		public int Id => 0;

		[ExcludeFromDocs]
		public static bool operator ==(in HierarchyNodeType lhs, in HierarchyNodeType rhs)
		{
			return false;
		}

		[ExcludeFromDocs]
		public bool Equals(HierarchyNodeType other)
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
	}
}
