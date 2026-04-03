using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenu("Post-processing/Chromatic Aberration")]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	public sealed class ChromaticAberration : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("Use the slider to set the strength of the Chromatic Aberration effect.")]
		public ClampedFloatParameter intensity;

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
