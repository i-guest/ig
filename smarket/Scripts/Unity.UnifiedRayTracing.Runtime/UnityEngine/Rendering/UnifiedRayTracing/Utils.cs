using System.Diagnostics;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal static class Utils
	{
		public static void Destroy(Object obj)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void CheckArgIsNotNull(object obj, string argName)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void CheckArg(bool condition, string message)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void CheckArgRange<T>(T value, T minIncluded, T maxExcluded, string argName)
		{
		}
	}
}
