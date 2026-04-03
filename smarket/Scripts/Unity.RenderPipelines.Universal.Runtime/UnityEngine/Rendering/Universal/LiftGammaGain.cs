using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenu("Post-processing/Lift, Gamma, Gain")]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent
	{
		public Vector4Parameter lift;

		public Vector4Parameter gamma;

		public Vector4Parameter gain;

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
