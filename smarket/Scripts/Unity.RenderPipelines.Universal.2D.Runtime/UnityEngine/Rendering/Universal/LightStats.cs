namespace UnityEngine.Rendering.Universal
{
	internal struct LightStats
	{
		public int totalLights;

		public int totalShadowLights;

		public int totalShadows;

		public int totalNormalMapUsage;

		public int totalVolumetricUsage;

		public int totalVolumetricShadowUsage;

		public uint blendStylesUsed;

		public uint blendStylesWithLights;

		public bool useLights => false;

		public bool useShadows => false;

		public bool useVolumetricLights => false;

		public bool useVolumetricShadowLights => false;

		public bool useNormalMap => false;
	}
}
