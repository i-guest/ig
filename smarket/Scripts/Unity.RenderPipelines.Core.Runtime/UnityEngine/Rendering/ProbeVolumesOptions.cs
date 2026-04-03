using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	[VolumeComponentMenu("Lighting/Adaptive Probe Volumes Options")]
	[SupportedOnRenderPipeline(new Type[] { })]
	[DisplayInfo(name = "Adaptive Probe Volumes Options")]
	public sealed class ProbeVolumesOptions : VolumeComponent
	{
		[Tooltip("The overridden normal bias to be applied to the world position when sampling the Adaptive Probe Volumes data structure. Unit is meters.")]
		public ClampedFloatParameter normalBias;

		[Tooltip("A bias alongside the view vector to be applied to the world position when sampling the Adaptive Probe Volumes data structure. Unit is meters.")]
		public ClampedFloatParameter viewBias;

		[Tooltip("Whether to scale the bias for Adaptive Probe Volumes by the minimum distance between probes.")]
		public BoolParameter scaleBiasWithMinProbeDistance;

		[Tooltip("Noise to be applied to the sampling position. It can hide seams issues between subdivision levels, but introduces noise.")]
		public ClampedFloatParameter samplingNoise;

		[Tooltip("Whether to animate the noise when TAA is enabled. It can potentially remove the visible noise patterns.")]
		public BoolParameter animateSamplingNoise;

		[Tooltip("Method used to reduce leaks. Currently available modes are crude, but cheap methods.")]
		public APVLeakReductionModeParameter leakReductionMode;

		[Obsolete("This parameter isn't used anymore. #from(6000.0)")]
		public ClampedFloatParameter minValidDotProductValue;

		[Tooltip("When enabled, reflection probe normalization can only decrease the reflection intensity.")]
		public BoolParameter occlusionOnlyReflectionNormalization;

		[AdditionalProperty]
		[Tooltip("Global probe volumes weight. Allows for fading out probe volumes influence falling back to ambient probe.")]
		public ClampedFloatParameter intensityMultiplier;

		[AdditionalProperty]
		[Tooltip("Multiplier applied on the sky lighting when using sky occlusion.")]
		public ClampedFloatParameter skyOcclusionIntensityMultiplier;

		[AdditionalProperty]
		[Tooltip("Offset applied at runtime to probe positions in world space.\nThis is not considered while baking.")]
		public Vector3Parameter worldOffset;
	}
}
