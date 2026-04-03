using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public static class svd
	{
		public const float k_EpsilonDeterminant = 1E-06f;

		public const float k_EpsilonRCP = 1E-09f;

		public const float k_EpsilonNormalSqrt = 1E-15f;

		public const float k_EpsilonNormal = 1E-30f;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void condSwap(bool c, ref float x, ref float y)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void condNegSwap(bool c, ref float3 x, ref float3 y)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static quaternion condNegSwapQuat(bool c, quaternion q, float4 mask)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void sortSingularValues(ref float3x3 b, ref quaternion v)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static quaternion approxGivensQuat(float3 pq, float4 mask)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static quaternion qrGivensQuat(float2 pq, float4 mask)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static quaternion givensQRFactorization(float3x3 b, out float3x3 r)
		{
			r = default(float3x3);
			return default(quaternion);
		}

		private static quaternion jacobiIteration(ref float3x3 s, int iterations = 5)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float3 singularValuesDecomposition(float3x3 a, out quaternion u, out quaternion v)
		{
			u = default(quaternion);
			v = default(quaternion);
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float3 rcpsafe(float3 x, float epsilon = 1E-09f)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 svdInverse(float3x3 a)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion svdRotation(float3x3 a)
		{
			return default(quaternion);
		}
	}
}
