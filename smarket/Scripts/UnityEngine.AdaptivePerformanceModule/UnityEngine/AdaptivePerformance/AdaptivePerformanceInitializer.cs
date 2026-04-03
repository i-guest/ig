using UnityEngine.Scripting;

namespace UnityEngine.AdaptivePerformance
{
	internal static class AdaptivePerformanceInitializer
	{
		private static AdaptivePerformanceManagerSpawner s_Spawner;

		[RequiredByNativeCode(false)]
		public static void AutoInitializeAdaptivePerformanceManaged()
		{
		}

		private static void InitializeSpawner(bool isAuto)
		{
		}
	}
}
