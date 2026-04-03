using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine
{
	[MovedFrom("UnityEditor")]
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule" })]
	internal class NumericFieldDraggerUtility
	{
		private static bool s_UseYSign;

		public static float Acceleration(bool shiftPressed, bool altPressed)
		{
			return 0f;
		}

		public static float NiceDelta(Vector2 deviceDelta, float acceleration)
		{
			return 0f;
		}

		public static double CalculateFloatDragSensitivity(double value)
		{
			return 0.0;
		}

		public static double CalculateFloatDragSensitivity(double value, double minValue, double maxValue)
		{
			return 0.0;
		}

		public static long CalculateIntDragSensitivity(long value)
		{
			return 0L;
		}

		public static ulong CalculateIntDragSensitivity(ulong value)
		{
			return 0uL;
		}

		public static double CalculateIntDragSensitivity(double value)
		{
			return 0.0;
		}

		public static long CalculateIntDragSensitivity(long value, long minValue, long maxValue)
		{
			return 0L;
		}
	}
}
