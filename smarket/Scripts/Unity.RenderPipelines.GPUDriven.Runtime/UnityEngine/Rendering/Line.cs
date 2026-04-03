using Unity.Mathematics;

namespace UnityEngine.Rendering
{
	internal struct Line
	{
		public float3 m;

		public float3 t;

		internal static Line LineOfPlaneIntersectingPlane(float4 a, float4 b)
		{
			return default(Line);
		}

		internal static float4 PlaneContainingLineAndPoint(Line a, float3 b)
		{
			return default(float4);
		}

		internal static float4 PlaneContainingLineWithNormalPerpendicularToVector(Line a, float3 b)
		{
			return default(float4);
		}
	}
}
