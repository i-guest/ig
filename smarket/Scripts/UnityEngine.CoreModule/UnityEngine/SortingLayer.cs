using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	public struct SortingLayer
	{
		private int m_Id;

		public int id => 0;

		public string name => null;

		public int value => 0;

		public static SortingLayer[] layers => null;

		[FreeFunction("GetTagManager().GetSortingLayerIDs")]
		private static int[] GetSortingLayerIDsInternal()
		{
			return null;
		}

		[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
		public static int GetLayerValueFromID(int id)
		{
			return 0;
		}

		[FreeFunction("GetTagManager().GetSortingLayerUniqueIDFromName")]
		public static int NameToID(string name)
		{
			return 0;
		}

		[FreeFunction("GetTagManager().GetSortingLayerNameFromUniqueID")]
		public static string IDToName(int id)
		{
			return null;
		}

		[FreeFunction("GetTagManager().IsSortingLayerUniqueIDValid")]
		public static bool IsValid(int id)
		{
			return false;
		}

		private static void GetSortingLayerIDsInternal_Injected(out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static int NameToID_Injected(ref ManagedSpanWrapper name)
		{
			return 0;
		}

		private static void IDToName_Injected(int id, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}
	}
}
