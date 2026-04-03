using System;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class SortingGroup : Behaviour
	{
		[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
		internal static int invalidSortingGroupID => 0;

		public int sortingLayerID => 0;

		public int sortingOrder => 0;

		[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
		internal static SortingGroup GetSortingGroupByIndex(int index)
		{
			return null;
		}

		private static IntPtr GetSortingGroupByIndex_Injected(int index)
		{
			return (IntPtr)0;
		}

		private static int get_sortingLayerID_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_sortingOrder_Injected(IntPtr _unity_self)
		{
			return 0;
		}
	}
}
