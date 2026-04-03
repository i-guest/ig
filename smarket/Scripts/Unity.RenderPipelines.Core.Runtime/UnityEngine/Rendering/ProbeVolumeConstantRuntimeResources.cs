using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	internal static class ProbeVolumeConstantRuntimeResources
	{
		private static ComputeBuffer m_SkySamplingDirectionsBuffer;

		private static ComputeBuffer m_AntiLeakDataBuffer;

		private const int NB_SKY_PRECOMPUTED_DIRECTIONS = 255;

		private static Vector3[] k_SkyDirections;

		private static uint[] k_AntiLeakData;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
		}

		internal static void Initialize()
		{
		}

		public static Vector3[] GetSkySamplingDirections()
		{
			return null;
		}

		internal static void Cleanup()
		{
		}

		private static Vector3[] GenerateSkyDirections()
		{
			return null;
		}
	}
}
