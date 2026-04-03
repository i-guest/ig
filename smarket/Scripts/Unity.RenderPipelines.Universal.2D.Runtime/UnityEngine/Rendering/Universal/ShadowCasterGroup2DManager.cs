using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	internal class ShadowCasterGroup2DManager
	{
		private static List<ShadowCasterGroup2D> s_ShadowCasterGroups;

		public static List<ShadowCasterGroup2D> shadowCasterGroups => null;

		public static void CacheValues()
		{
		}

		public static void AddShadowCasterGroupToList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list)
		{
		}

		public static void RemoveShadowCasterGroupFromList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list)
		{
		}

		private static CompositeShadowCaster2D FindTopMostCompositeShadowCaster(ShadowCaster2D shadowCaster)
		{
			return null;
		}

		public static int GetRendereringPriority(ShadowCaster2D shadowCaster)
		{
			return 0;
		}

		public static bool AddToShadowCasterGroup(ShadowCaster2D shadowCaster, ref ShadowCasterGroup2D shadowCasterGroup, ref int priority)
		{
			return false;
		}

		public static void RemoveFromShadowCasterGroup(ShadowCaster2D shadowCaster, ShadowCasterGroup2D shadowCasterGroup)
		{
		}

		public static void AddGroup(ShadowCasterGroup2D group)
		{
		}

		public static void RemoveGroup(ShadowCasterGroup2D group)
		{
		}
	}
}
