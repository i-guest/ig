using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	[Serializable]
	public struct GlobalDynamicResolutionSettings
	{
		public bool enabled;

		public bool useMipBias;

		[Obsolete("Obsolete, use advancedUpscalerNames list instead.")]
		public List<AdvancedUpscalers> advancedUpscalersByPriority;

		public List<string> advancedUpscalerNames;

		public uint DLSSPerfQualitySetting;

		public DynamicResolutionHandler.UpsamplerScheduleType DLSSInjectionPoint;

		public DynamicResolutionHandler.UpsamplerScheduleType TAAUInjectionPoint;

		public DynamicResolutionHandler.UpsamplerScheduleType STPInjectionPoint;

		public DynamicResolutionHandler.UpsamplerScheduleType defaultInjectionPoint;

		public bool DLSSUseOptimalSettings;

		[Range(0f, 1f)]
		public float DLSSSharpness;

		public uint DLSSRenderPresetForQuality;

		public uint DLSSRenderPresetForBalanced;

		public uint DLSSRenderPresetForPerformance;

		public uint DLSSRenderPresetForUltraPerformance;

		public uint DLSSRenderPresetForDLAA;

		public bool FSR2EnableSharpness;

		[Range(0f, 1f)]
		public float FSR2Sharpness;

		public bool FSR2UseOptimalSettings;

		public uint FSR2QualitySetting;

		public DynamicResolutionHandler.UpsamplerScheduleType FSR2InjectionPoint;

		public bool fsrOverrideSharpness;

		[Range(0f, 1f)]
		public float fsrSharpness;

		public float maxPercentage;

		public float minPercentage;

		public DynamicResolutionType dynResType;

		public DynamicResUpscaleFilter upsampleFilter;

		public bool forceResolution;

		public float forcedPercentage;

		public float lowResTransparencyMinimumThreshold;

		public float rayTracingHalfResThreshold;

		public float lowResSSGIMinimumThreshold;

		public float lowResVolumetricCloudsMinimumThreshold;

		[Obsolete("Obsolete, used only for data migration. Use the advancedUpscalersByPriority list instead to add the proper supported advanced upscaler by priority. #from(2023.3)")]
		public bool enableDLSS;

		public static GlobalDynamicResolutionSettings NewDefault()
		{
			return default(GlobalDynamicResolutionSettings);
		}
	}
}
