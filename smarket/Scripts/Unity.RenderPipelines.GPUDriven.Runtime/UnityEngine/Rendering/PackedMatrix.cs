using Unity.Mathematics;

namespace UnityEngine.Rendering
{
	internal struct PackedMatrix
	{
		public float4 packed0;

		public float4 packed1;

		public float4 packed2;

		public static PackedMatrix FromMatrix4x4(in Matrix4x4 m)
		{
			return default(PackedMatrix);
		}

		public static PackedMatrix FromFloat4x4(in float4x4 m)
		{
			return default(PackedMatrix);
		}
	}
}
