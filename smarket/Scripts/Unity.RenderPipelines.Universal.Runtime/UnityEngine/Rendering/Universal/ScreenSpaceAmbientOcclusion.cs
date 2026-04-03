namespace UnityEngine.Rendering.Universal
{
	[SupportedOnRenderer(typeof(UniversalRendererData))]
	[DisallowMultipleRendererFeature("Screen Space Ambient Occlusion")]
	[Tooltip("The Ambient Occlusion effect darkens creases, holes, intersections and surfaces that are close to each other.")]
	public class ScreenSpaceAmbientOcclusion : ScriptableRendererFeature
	{
		[SerializeField]
		private ScreenSpaceAmbientOcclusionSettings m_Settings;

		private Material m_Material;

		private ScreenSpaceAmbientOcclusionPass m_SSAOPass;

		private Shader m_Shader;

		private Texture2D[] m_BlueNoise256Textures;

		internal const string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT";

		internal const string k_AOBlueNoiseKeyword = "_BLUE_NOISE";

		internal const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";

		internal const string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW";

		internal const string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM";

		internal const string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH";

		internal const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";

		internal const string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW";

		internal const string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM";

		internal const string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH";

		internal ref ScreenSpaceAmbientOcclusionSettings settings
		{
			get
			{
				throw null;
			}
		}

		public override void Create()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private bool TryPrepareResources()
		{
			return false;
		}
	}
}
