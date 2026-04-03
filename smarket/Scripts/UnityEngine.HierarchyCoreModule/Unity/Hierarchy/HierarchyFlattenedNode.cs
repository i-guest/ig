using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace Unity.Hierarchy
{
	[NativeHeader("Modules/HierarchyCore/Public/HierarchyFlattenedNode.h")]
	public readonly struct HierarchyFlattenedNode : IEquatable<HierarchyFlattenedNode>
	{
		private static readonly HierarchyFlattenedNode s_Null;

		private readonly HierarchyNode m_Node;

		private readonly HierarchyNodeType m_Type;

		private readonly int m_Version;

		private readonly int m_ParentOffset;

		private readonly int m_NextSiblingOffset;

		private readonly int m_ChildIndex;

		private readonly int m_ChildrenCount;

		private readonly int m_Depth;

		public static ref readonly HierarchyFlattenedNode Null
		{
			get
			{
				throw null;
			}
		}

		public HierarchyNode Node => default(HierarchyNode);

		public int NextSiblingOffset => 0;

		public int Depth => 0;

		public HierarchyFlattenedNode()
		{
			m_Node = default(HierarchyNode);
			m_Type = default(HierarchyNodeType);
			m_Version = 0;
			m_ParentOffset = 0;
			m_NextSiblingOffset = 0;
			m_ChildIndex = 0;
			m_ChildrenCount = 0;
			m_Depth = 0;
		}

		[ExcludeFromDocs]
		public static bool operator ==(in HierarchyFlattenedNode lhs, in HierarchyFlattenedNode rhs)
		{
			return false;
		}

		[ExcludeFromDocs]
		public bool Equals(HierarchyFlattenedNode other)
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ref HierarchyNode GetNodeByRef(in HierarchyFlattenedNode hierarchyFlattenedNode)
		{
			throw null;
		}
	}
}
