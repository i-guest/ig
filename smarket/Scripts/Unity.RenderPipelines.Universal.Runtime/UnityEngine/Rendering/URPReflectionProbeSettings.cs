using System;
using UnityEngine.Categorization;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Rendering
{
	[Serializable]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[CategoryInfo(Name = "Lighting", Order = 21)]
	public class URPReflectionProbeSettings : IRenderPipelineGraphicsSettings
	{
		[SerializeField]
		[HideInInspector]
		private int version;

		[SerializeField]
		[Tooltip("Use ReflectionProbe rotation. Enabling this will improve the appearance of reflections when the ReflectionProbe isn't axis aligned, but may worsen performance on lower end platforms.")]
		private bool useReflectionProbeRotation;

		int IRenderPipelineGraphicsSettings.version => 0;

		public bool UseReflectionProbeRotation => false;
	}
}
