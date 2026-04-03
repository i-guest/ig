using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Camera/Light.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
	public sealed class Light : Behaviour
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private LightShape _003Cshape_003Ek__BackingField;

		private int m_BakedIndex;

		[NativeProperty("LightType")]
		public LightType type
		{
			get
			{
				return default(LightType);
			}
			set
			{
			}
		}

		public float spotAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float innerSpotAngle => 0f;

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float colorTemperature
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useColorTemperature => false;

		public float intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float bounceIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float luxAtDistance => 0f;

		public bool enableSpotReflector => false;

		public int shadowCustomResolution
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float shadowBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float shadowNormalBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float shadowNearPlane
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float range
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float dilatedRange => 0f;

		public Flare flare
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LightBakingOutput bakingOutput => default(LightBakingOutput);

		public int cullingMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int renderingLayerMask
		{
			set
			{
			}
		}

		public LightShadows shadows
		{
			[NativeMethod("GetShadowType")]
			get
			{
				return default(LightShadows);
			}
			[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = true, ThrowsException = true)]
			set
			{
			}
		}

		public float shadowStrength
		{
			get
			{
				return 0f;
			}
			[FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = true)]
			set
			{
			}
		}

		public LightShadowResolution shadowResolution
		{
			get
			{
				return default(LightShadowResolution);
			}
			set
			{
			}
		}

		private LightShadowResolution ShadowResolution
		{
			get
			{
				return default(LightShadowResolution);
			}
			[FreeFunction("Light_Bindings::SetShadowResolution", HasExplicitThis = true, ThrowsException = true)]
			set
			{
			}
		}

		[Obsolete("Light.cookieSize has been deprecated. Use Light.cookieSize2D instead.", false)]
		public float cookieSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 cookieSize2D
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Texture cookie
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LightRenderMode renderMode
		{
			get
			{
				return default(LightRenderMode);
			}
			[FreeFunction("Light_Bindings::SetRenderMode", HasExplicitThis = true, ThrowsException = true)]
			set
			{
			}
		}

		public Vector2 areaSize => default(Vector2);

		private static void LogWarningOnlyBuiltIn([CallerMemberName] string propertyName = "")
		{
		}

		private static LightType get_type_Injected(IntPtr _unity_self)
		{
			return default(LightType);
		}

		private static void set_type_Injected(IntPtr _unity_self, LightType value)
		{
		}

		private static float get_spotAngle_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_spotAngle_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_innerSpotAngle_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void get_color_Injected(IntPtr _unity_self, out Color ret)
		{
			ret = default(Color);
		}

		private static void set_color_Injected(IntPtr _unity_self, [In] ref Color value)
		{
		}

		private static float get_colorTemperature_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_colorTemperature_Injected(IntPtr _unity_self, float value)
		{
		}

		private static bool get_useColorTemperature_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static float get_intensity_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_intensity_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_bounceIntensity_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_bounceIntensity_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_luxAtDistance_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static bool get_enableSpotReflector_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static int get_shadowCustomResolution_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_shadowCustomResolution_Injected(IntPtr _unity_self, int value)
		{
		}

		private static float get_shadowBias_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_shadowBias_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_shadowNormalBias_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_shadowNormalBias_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_shadowNearPlane_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_shadowNearPlane_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_range_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_range_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_dilatedRange_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static IntPtr get_flare_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_flare_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static void get_bakingOutput_Injected(IntPtr _unity_self, out LightBakingOutput ret)
		{
			ret = default(LightBakingOutput);
		}

		private static int get_cullingMask_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_cullingMask_Injected(IntPtr _unity_self, int value)
		{
		}

		private static void set_renderingLayerMask_Injected(IntPtr _unity_self, int value)
		{
		}

		private static LightShadows get_shadows_Injected(IntPtr _unity_self)
		{
			return default(LightShadows);
		}

		private static void set_shadows_Injected(IntPtr _unity_self, LightShadows value)
		{
		}

		private static float get_shadowStrength_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_shadowStrength_Injected(IntPtr _unity_self, float value)
		{
		}

		private static LightShadowResolution get_ShadowResolution_Injected(IntPtr _unity_self)
		{
			return default(LightShadowResolution);
		}

		private static void set_ShadowResolution_Injected(IntPtr _unity_self, LightShadowResolution value)
		{
		}

		private static void get_cookieSize2D_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_cookieSize2D_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static IntPtr get_cookie_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_cookie_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static LightRenderMode get_renderMode_Injected(IntPtr _unity_self)
		{
			return default(LightRenderMode);
		}

		private static void set_renderMode_Injected(IntPtr _unity_self, LightRenderMode value)
		{
		}

		private static void get_areaSize_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}
	}
}
