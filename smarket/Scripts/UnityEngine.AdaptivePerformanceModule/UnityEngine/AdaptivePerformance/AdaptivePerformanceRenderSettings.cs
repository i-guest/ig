namespace UnityEngine.AdaptivePerformance
{
	public static class AdaptivePerformanceRenderSettings
	{
		private static float s_MaxShadowDistanceMultiplier;

		private static float s_ShadowResolutionMultiplier;

		private static float s_RenderScaleMultiplier;

		private static float s_DecalsMaxDistance;

		public static float MainLightShadowmapResolutionMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float DecalsDrawDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static int MainLightShadowCascadesCountBias { get; set; }

		public static int ShadowQualityBias { get; set; }

		public static float LutBias { get; set; }

		public static float MaxShadowDistanceMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float RenderScaleMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static int AntiAliasingQualityBias { get; set; }

		public static bool SkipDynamicBatching { get; set; }

		public static bool SkipFrontToBackSorting { get; set; }

		public static bool SkipTransparentObjects { get; set; }
	}
}
