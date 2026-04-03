using System;
using Unity.Mathematics;

namespace UnityEngine.Rendering
{
	[Serializable]
	internal struct AABB
	{
		public float3 center;

		public float3 extents;

		public float3 min => default(float3);

		public float3 max => default(float3);

		public override string ToString()
		{
			return null;
		}

		private static float3 RotateExtents(float3 extents, float3 m0, float3 m1, float3 m2)
		{
			return default(float3);
		}

		public static AABB Transform(float4x4 transform, AABB localBounds)
		{
			return default(AABB);
		}
	}
}
