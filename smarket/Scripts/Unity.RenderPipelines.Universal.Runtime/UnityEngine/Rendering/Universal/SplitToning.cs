using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenu("Post-processing/Split Toning")]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	public sealed class SplitToning : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("The color to use for shadows.")]
		public ColorParameter shadows;

		[Tooltip("The color to use for highlights.")]
		public ColorParameter highlights;

		[Tooltip("Balance between the colors in the highlights and shadows.")]
		public ClampedFloatParameter balance;

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
