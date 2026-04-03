using UnityEngine.Bindings;

namespace Unity.Hierarchy
{
	[NativeHeader("Modules/HierarchyCore/Public/HierarchyPropertyDescriptor.h")]
	public struct HierarchyPropertyDescriptor
	{
		private int m_Size;

		private HierarchyPropertyStorageType m_Type;

		public int Size
		{
			set
			{
			}
		}

		public HierarchyPropertyStorageType Type
		{
			set
			{
			}
		}
	}
}
