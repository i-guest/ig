using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal static class WorldSpaceDataStore
	{
		private static Dictionary<uint, WorldSpaceData> m_WorldSpaceData;

		public static void SetWorldSpaceData(VisualElement ve, WorldSpaceData data)
		{
		}

		public static WorldSpaceData GetWorldSpaceData(VisualElement ve)
		{
			return default(WorldSpaceData);
		}

		public static void ClearWorldSpaceData(VisualElement ve)
		{
		}

		public static void ClearLocalBounds3DData(VisualElement ve)
		{
		}
	}
}
