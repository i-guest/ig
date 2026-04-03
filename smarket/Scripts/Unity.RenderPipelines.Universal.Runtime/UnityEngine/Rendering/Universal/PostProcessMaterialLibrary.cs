namespace UnityEngine.Rendering.Universal
{
	internal class PostProcessMaterialLibrary
	{
		public readonly Material stopNaN;

		public readonly Material subpixelMorphologicalAntialiasing;

		public readonly Material gaussianDepthOfField;

		public readonly Material gaussianDepthOfFieldCoC;

		public readonly Material bokehDepthOfField;

		public readonly Material bokehDepthOfFieldCoC;

		public readonly Material temporalAntialiasing;

		public readonly Material motionBlur;

		public readonly Material paniniProjection;

		public readonly Material bloom;

		public readonly Material[] bloomUpsample;

		public readonly Material lensFlareScreenSpace;

		public readonly Material lensFlareDataDriven;

		public readonly Material uber;

		public readonly Material scalingSetup;

		public readonly Material easu;

		public readonly Material finalPass;

		internal PostProcessData m_Resources;

		public PostProcessData resources => null;

		public PostProcessMaterialLibrary(PostProcessData data)
		{
		}

		private Material Load(Shader shader)
		{
			return null;
		}

		internal void Cleanup()
		{
		}
	}
}
