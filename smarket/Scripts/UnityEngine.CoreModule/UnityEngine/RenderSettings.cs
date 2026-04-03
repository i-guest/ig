using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
	[NativeHeader("Runtime/Camera/RenderSettings.h")]
	public sealed class RenderSettings : Object
	{
		[NativeProperty("UseFog")]
		public static bool fog => false;

		public static Color ambientSkyColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public static Color ambientEquatorColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public static Color ambientGroundColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public static Color subtractiveShadowColor => default(Color);

		[NativeProperty("SkyboxMaterial")]
		public static Material skybox => null;

		public static Light sun => null;

		public static SphericalHarmonicsL2 ambientProbe
		{
			[NativeMethod("GetFinalAmbientProbe")]
			get
			{
				return default(SphericalHarmonicsL2);
			}
		}

		public static float reflectionIntensity => 0f;

		private static void get_ambientSkyColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		private static void set_ambientSkyColor_Injected([In] ref Color value)
		{
		}

		private static void get_ambientEquatorColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		private static void set_ambientEquatorColor_Injected([In] ref Color value)
		{
		}

		private static void get_ambientGroundColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		private static void set_ambientGroundColor_Injected([In] ref Color value)
		{
		}

		private static void get_subtractiveShadowColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		private static IntPtr get_skybox_Injected()
		{
			return (IntPtr)0;
		}

		private static IntPtr get_sun_Injected()
		{
			return (IntPtr)0;
		}

		private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret)
		{
			ret = default(SphericalHarmonicsL2);
		}
	}
}
