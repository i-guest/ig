using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenu("Post-processing/Screen Space Lens Flare")]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[DisplayInfo(name = "Screen Space Lens Flare")]
	public class ScreenSpaceLensFlare : VolumeComponent, IPostProcessComponent
	{
		public MinFloatParameter intensity;

		public ColorParameter tintColor;

		[AdditionalProperty]
		public ClampedIntParameter bloomMip;

		[Header("Flares")]
		public MinFloatParameter firstFlareIntensity;

		public MinFloatParameter secondaryFlareIntensity;

		public MinFloatParameter warpedFlareIntensity;

		[AdditionalProperty]
		public Vector2Parameter warpedFlareScale;

		public ClampedIntParameter samples;

		[AdditionalProperty]
		public ClampedFloatParameter sampleDimmer;

		public ClampedFloatParameter vignetteEffect;

		public ClampedFloatParameter startingPosition;

		public ClampedFloatParameter scale;

		[Header("Streaks")]
		public MinFloatParameter streaksIntensity;

		public ClampedFloatParameter streaksLength;

		public FloatParameter streaksOrientation;

		public ClampedFloatParameter streaksThreshold;

		[SerializeField]
		[AdditionalProperty]
		public ScreenSpaceLensFlareResolutionParameter resolution;

		[Header("Chromatic Abberation")]
		public ClampedFloatParameter chromaticAbberationIntensity;

		public bool IsActive()
		{
			return false;
		}

		public bool IsStreaksActive()
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
