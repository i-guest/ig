using System;
using UnityEngine.Categorization;

namespace UnityEngine.Rendering
{
	[Serializable]
	[SupportedOnRenderPipeline(new Type[] { })]
	[CategoryInfo(Name = "Additional Shader Stripping Settings", Order = 40)]
	[ElementInfo(Order = 0)]
	public class ShaderStrippingSetting : IRenderPipelineGraphicsSettings
	{
		internal enum Version
		{
			Initial = 0
		}

		[SerializeField]
		[HideInInspector]
		private Version m_Version;

		[SerializeField]
		[Tooltip("Controls whether to output shader variant information to a file.")]
		private bool m_ExportShaderVariants;

		[SerializeField]
		[Tooltip("Controls the level of logging of shader variant information outputted during the build process. Information appears in the Unity Console when the build finishes.")]
		private ShaderVariantLogLevel m_ShaderVariantLogLevel;

		[SerializeField]
		[Tooltip("When enabled, all debug display shader variants are removed when you build for the Unity Player. This decreases build time, but prevents the use of most Rendering Debugger features in Player builds.")]
		private bool m_StripRuntimeDebugShaders;

		public int version => 0;

		bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => false;

		public bool exportShaderVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ShaderVariantLogLevel shaderVariantLogLevel
		{
			get
			{
				return default(ShaderVariantLogLevel);
			}
			set
			{
			}
		}

		public bool stripRuntimeDebugShaders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
