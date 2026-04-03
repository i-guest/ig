using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenu("Post-processing/Panini Projection")]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	public sealed class PaniniProjection : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("Panini projection distance.")]
		public ClampedFloatParameter distance;

		[Tooltip("Panini projection crop to fit.")]
		public ClampedFloatParameter cropToFit;

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
