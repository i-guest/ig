using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[StaticAccessor("GetGraphicsSettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
	public sealed class GraphicsSettings : Object
	{
		private static Lazy<RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings;

		public static bool lightsUseLinearIntensity
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool lightsUseColorTemperature
		{
			set
			{
			}
		}

		public static bool useScriptableRenderPipelineBatching
		{
			set
			{
			}
		}

		[NativeName("CurrentRenderPipeline")]
		private static ScriptableObject INTERNAL_currentRenderPipeline => null;

		public static RenderPipelineAsset currentRenderPipeline => null;

		public static bool isScriptableRenderPipelineEnabled => false;

		public static Type currentRenderPipelineAssetType => null;

		[NativeName("DefaultRenderPipeline")]
		private static ScriptableObject INTERNAL_defaultRenderPipeline
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static RenderPipelineAsset defaultRenderPipeline
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash)
		{
			return false;
		}

		public static bool HasShaderDefine(BuiltinShaderDefine defineHash)
		{
			return false;
		}

		[RequiredByNativeCode]
		[VisibleToOtherModules]
		internal static Shader GetDefaultShader(DefaultShaderType type)
		{
			return null;
		}

		[VisibleToOtherModules]
		[RequiredByNativeCode]
		internal static Material GetDefaultMaterial(DefaultMaterialType type)
		{
			return null;
		}

		[NativeName("GetSettingsForRenderPipeline")]
		private static Object Internal_GetSettingsForRenderPipeline(string renderpipelineName)
		{
			return null;
		}

		public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>() where T : RenderPipeline
		{
			return null;
		}

		private static RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings()
		{
			return null;
		}

		internal static void ValidateSetRenderPipelineAsset(RenderPipelineAsset newRenderPipelineAsset)
		{
		}

		public static bool TryGetCurrentRenderPipelineGlobalSettings(out RenderPipelineGlobalSettings asset)
		{
			asset = null;
			return false;
		}

		public static T GetRenderPipelineSettings<T>() where T : class, IRenderPipelineGraphicsSettings
		{
			return null;
		}

		public static bool TryGetRenderPipelineSettings<T>(out T settings) where T : class, IRenderPipelineGraphicsSettings
		{
			settings = null;
			return false;
		}

		private static IntPtr get_INTERNAL_currentRenderPipeline_Injected()
		{
			return (IntPtr)0;
		}

		private static IntPtr get_INTERNAL_defaultRenderPipeline_Injected()
		{
			return (IntPtr)0;
		}

		private static void set_INTERNAL_defaultRenderPipeline_Injected(IntPtr value)
		{
		}

		private static IntPtr Internal_GetSettingsForRenderPipeline_Injected(ref ManagedSpanWrapper renderpipelineName)
		{
			return (IntPtr)0;
		}
	}
}
