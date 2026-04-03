using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace Unity.Hierarchy
{
	[NativeHeader("Modules/HierarchyCore/Public/HierarchyNode.h")]
	public readonly struct HierarchyNode : IEquatable<HierarchyNode>
	{
		private static readonly HierarchyNode s_Null;

		private readonly int m_Id;

		private readonly int m_Version;

		public static ref readonly HierarchyNode Null
		{
			get
			{
				throw null;
			}
		}

		public int Id => 0;

		public int Version => 0;

		public HierarchyNode()
		{
			m_Id = 0;
			m_Version = 0;
		}

		[ExcludeFromDocs]
		public static bool operator ==(in HierarchyNode lhs, in HierarchyNode rhs)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool operator !=(in HierarchyNode lhs, in HierarchyNode rhs)
		{
			return false;
		}

		[ExcludeFromDocs]
		public bool Equals(HierarchyNode other)
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
