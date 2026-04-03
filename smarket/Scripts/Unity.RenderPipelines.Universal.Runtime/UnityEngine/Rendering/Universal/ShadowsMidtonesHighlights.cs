using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenu("Post-processing/Shadows, Midtones, Highlights")]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent
	{
		public Vector4Parameter shadows;

		public Vector4Parameter midtones;

		public Vector4Parameter highlights;

		[Header("Shadow Limits")]
		[Tooltip("Start point of the transition between shadows and midtones.")]
		public MinFloatParameter shadowsStart;

		[Tooltip("End point of the transition between shadows and midtones.")]
		public MinFloatParameter shadowsEnd;

		[Header("Highlight Limits")]
		[Tooltip("Start point of the transition between midtones and highlights.")]
		public MinFloatParameter highlightsStart;

		[Tooltip("End point of the transition between midtones and highlights.")]
		public MinFloatParameter highlightsEnd;

		public bool IsActive()
		{
			return false;
		}

		[Obsolete("Unused. #from(2023.1)")]
		public bool IsTileCompatible()
		{
			return false;
		}
	}
}
