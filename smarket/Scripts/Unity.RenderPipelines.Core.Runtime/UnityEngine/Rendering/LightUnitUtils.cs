using System;

namespace UnityEngine.Rendering
{
	public static class LightUnitUtils
	{
		public const float SphereSolidAngle = (float)Math.PI * 4f;

		private static float k_LuminanceToEvFactor => 0f;

		private static float k_EvToLuminanceFactor => 0f;

		public static LightUnit GetNativeLightUnit(LightType lightType)
		{
			return default(LightUnit);
		}

		public static bool IsLightUnitSupported(LightType lightType, LightUnit lightUnit)
		{
			return false;
		}

		public static float GetSolidAngleFromPointLight()
		{
			return 0f;
		}

		public static float GetSolidAngleFromSpotLight(float spotAngle)
		{
			return 0f;
		}

		public static float GetSolidAngleFromPyramidLight(float spotAngle, float aspectRatio)
		{
			return 0f;
		}

		internal static float GetSolidAngle(LightType lightType, bool spotReflector, float spotAngle, float aspectRatio)
		{
			return 0f;
		}

		public static float GetAreaFromRectangleLight(float rectSizeX, float rectSizeY)
		{
			return 0f;
		}

		public static float GetAreaFromRectangleLight(Vector2 rectSize)
		{
			return 0f;
		}

		public static float GetAreaFromDiscLight(float discRadius)
		{
			return 0f;
		}

		public static float GetAreaFromTubeLight(float tubeLength)
		{
			return 0f;
		}

		public static float LumenToCandela(float lumen, float solidAngle)
		{
			return 0f;
		}

		public static float CandelaToLumen(float candela, float solidAngle)
		{
			return 0f;
		}

		public static float LumenToNits(float lumen, float area)
		{
			return 0f;
		}

		public static float NitsToLumen(float nits, float area)
		{
			return 0f;
		}

		public static float LuxToCandela(float lux, float distance)
		{
			return 0f;
		}

		public static float CandelaToLux(float candela, float distance)
		{
			return 0f;
		}

		public static float Ev100ToNits(float ev100)
		{
			return 0f;
		}

		public static float NitsToEv100(float nits)
		{
			return 0f;
		}

		public static float Ev100ToCandela(float ev100)
		{
			return 0f;
		}

		public static float CandelaToEv100(float candela)
		{
			return 0f;
		}

		internal static float ConvertIntensityInternal(float intensity, LightUnit fromUnit, LightUnit toUnit, LightType lightType, float area, float luxAtDistance, float solidAngle)
		{
			return 0f;
		}

		public static float ConvertIntensity(Light light, float intensity, LightUnit fromUnit, LightUnit toUnit)
		{
			return 0f;
		}
	}
}
