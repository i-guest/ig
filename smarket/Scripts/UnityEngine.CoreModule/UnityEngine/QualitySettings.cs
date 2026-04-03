using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/QualitySettings.h")]
	[StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	public sealed class QualitySettings : Object
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<int, int> activeQualityLevelChanged;

		[NativeProperty("ShadowQuality")]
		public static ShadowQuality shadows
		{
			get
			{
				return default(ShadowQuality);
			}
			set
			{
			}
		}

		[NativeProperty("ShadowmaskMode")]
		public static ShadowmaskMode shadowmaskMode => default(ShadowmaskMode);

		[NativeProperty("LODBias")]
		public static float lodBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("MeshLODThreshold")]
		public static float meshLodThreshold => 0f;

		public static int globalTextureMipmapLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int maximumLODLevel => 0;

		public static bool enableLODCrossFade
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int vSyncCount
		{
			set
			{
			}
		}

		public static int antiAliasing
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool billboardsFaceCameraPosition => false;

		[NativeName("RenderPipeline")]
		private static ScriptableObject INTERNAL_renderPipeline => null;

		public static RenderPipelineAsset renderPipeline => null;

		[NativeProperty("QualitySettingsNames")]
		public static string[] names => null;

		public static ColorSpace activeColorSpace
		{
			[NativeName("GetColorSpace")]
			[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
			get
			{
				return default(ColorSpace);
			}
		}

		[RequiredByNativeCode]
		internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel)
		{
		}

		public static void SetQualityLevel(int index)
		{
		}

		[NativeName("GetCurrentIndex")]
		public static int GetQualityLevel()
		{
			return 0;
		}

		[NativeName("SetCurrentIndex")]
		public static void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges)
		{
		}

		private static IntPtr get_INTERNAL_renderPipeline_Injected()
		{
			return (IntPtr)0;
		}
	}
}
