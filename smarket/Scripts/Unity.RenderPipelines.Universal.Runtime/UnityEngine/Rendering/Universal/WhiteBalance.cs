using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenu("Post-processing/White Balance")]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("Sets the white balance to a custom color temperature.")]
		public ClampedFloatParameter temperature;

		[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
		public ClampedFloatParameter tint;

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
