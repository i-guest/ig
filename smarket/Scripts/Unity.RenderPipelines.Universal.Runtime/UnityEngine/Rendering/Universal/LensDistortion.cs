using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenu("Post-processing/Lens Distortion")]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	public sealed class LensDistortion : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("Total distortion amount.")]
		public ClampedFloatParameter intensity;

		[Tooltip("Intensity multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
		public ClampedFloatParameter xMultiplier;

		[Tooltip("Intensity multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
		public ClampedFloatParameter yMultiplier;

		[Tooltip("Distortion center point. 0.5,0.5 is center of the screen.")]
		public Vector2Parameter center;

		[Tooltip("Controls global screen scaling for the distortion effect. Use this to hide the screen borders when using high \"Intensity.\"")]
		public ClampedFloatParameter scale;

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
