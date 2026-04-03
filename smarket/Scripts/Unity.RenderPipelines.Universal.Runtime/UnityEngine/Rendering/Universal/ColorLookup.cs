using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenu("Post-processing/Color Lookup")]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	public sealed class ColorLookup : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("A 2D Lookup Texture (LUT) to use for color grading.")]
		public TextureParameter texture;

		[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
		public ClampedFloatParameter contribution;

		public bool IsActive()
		{
			return false;
		}

		[Obsolete("Unused. #from(2023.1)")]
		public bool IsTileCompatible()
		{
			return false;
		}

		public bool ValidateLUT()
		{
			return false;
		}
	}
}
