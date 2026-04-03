using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	public struct RTHandleAllocInfo
	{
		public int slices { get; set; }

		public GraphicsFormat format { get; set; }

		public FilterMode filterMode { get; set; }

		public TextureWrapMode wrapModeU { get; set; }

		public TextureWrapMode wrapModeV { get; set; }

		public TextureWrapMode wrapModeW { get; set; }

		public TextureDimension dimension { get; set; }

		public bool enableRandomWrite { get; set; }

		public bool useMipMap { get; set; }

		public bool autoGenerateMips { get; set; }

		public bool isShadowMap { get; set; }

		public int anisoLevel { get; set; }

		public float mipMapBias { get; set; }

		public MSAASamples msaaSamples { get; set; }

		public bool bindTextureMS { get; set; }

		public bool useDynamicScale { get; set; }

		public bool useDynamicScaleExplicit { get; set; }

		public RenderTextureMemoryless memoryless { get; set; }

		public VRTextureUsage vrUsage { get; set; }

		public bool enableShadingRate { get; set; }

		public string name { get; set; }

		public RTHandleAllocInfo(string name = "")
		{
			slices = 0;
			format = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapModeU = default(TextureWrapMode);
			wrapModeV = default(TextureWrapMode);
			wrapModeW = default(TextureWrapMode);
			dimension = default(TextureDimension);
			enableRandomWrite = false;
			useMipMap = false;
			autoGenerateMips = false;
			isShadowMap = false;
			anisoLevel = 0;
			mipMapBias = 0f;
			msaaSamples = default(MSAASamples);
			bindTextureMS = false;
			useDynamicScale = false;
			useDynamicScaleExplicit = false;
			memoryless = default(RenderTextureMemoryless);
			vrUsage = default(VRTextureUsage);
			enableShadingRate = false;
			this.name = null;
		}
	}
}
