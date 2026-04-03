using Unity.Mathematics;

namespace UnityEngine.Rendering
{
	public static class ColorSpaceUtils
	{
		public static readonly float3x3 Rec709ToRec2020Mat;

		public static readonly float3x3 Rec709ToP3D65Mat;

		public static readonly float3x3 Rec2020ToRec709Mat;

		public static readonly float3x3 Rec2020ToP3D65Mat;

		public static readonly float3x3 P3D65ToRec2020Mat;
	}
}
