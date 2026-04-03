using Unity.Mathematics;

namespace UnityEngine.Rendering.RadeonRays
{
	internal struct Transform
	{
		public float4 row0;

		public float4 row1;

		public float4 row2;

		public Transform(float4 row0, float4 row1, float4 row2)
		{
			this.row0 = default(float4);
			this.row1 = default(float4);
			this.row2 = default(float4);
		}

		public static Transform Identity()
		{
			return default(Transform);
		}

		public static Transform Translation(float3 translation)
		{
			return default(Transform);
		}

		public static Transform Scale(float3 scale)
		{
			return default(Transform);
		}

		public static Transform TRS(float3 translation, float3 rotation, float3 scale)
		{
			return default(Transform);
		}

		public Transform Inverse()
		{
			return default(Transform);
		}
	}
}
