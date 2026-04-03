using System.Runtime.InteropServices;

namespace UnityEngine.UIElements.Layout
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct LayoutDefaults
	{
		public static readonly FixedBuffer9<LayoutValue> EdgeValuesUnit;

		public static readonly float[] DimensionValues;

		public static readonly FixedBuffer2<LayoutValue> DimensionValuesUnit;

		public static readonly FixedBuffer2<LayoutValue> DimensionValuesAutoUnit;
	}
}
