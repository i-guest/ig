using Unity.Mathematics;

namespace UnityEngine.Rendering.RadeonRays
{
	internal class AABB
	{
		public float3 Min;

		public float3 Max;

		public AABB()
		{
		}

		public AABB(float3 min, float3 max)
		{
		}

		public void Encapsulate(AABB aabb)
		{
		}

		public void Encapsulate(float3 point)
		{
		}

		public bool Contains(AABB rhs)
		{
			return false;
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
