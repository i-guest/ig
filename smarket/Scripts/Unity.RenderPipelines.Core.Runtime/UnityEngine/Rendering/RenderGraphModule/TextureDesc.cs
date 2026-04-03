using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.RenderGraphModule
{
	public struct TextureDesc
	{
		public TextureSizeMode sizeMode;

		public int width;

		public int height;

		public int slices;

		public Vector2 scale;

		public ScaleFunc func;

		public GraphicsFormat format;

		public FilterMode filterMode;

		public TextureWrapMode wrapMode;

		public TextureDimension dimension;

		public bool enableRandomWrite;

		public bool useMipMap;

		public bool autoGenerateMips;

		public bool isShadowMap;

		public int anisoLevel;

		public float mipMapBias;

		public MSAASamples msaaSamples;

		public bool bindTextureMS;

		public bool useDynamicScale;

		public bool useDynamicScaleExplicit;

		public RenderTextureMemoryless memoryless;

		public VRTextureUsage vrUsage;

		public bool enableShadingRate;

		public string name;

		public FastMemoryDesc fastMemoryDesc;

		public bool fallBackToBlackTexture;

		public bool disableFallBackToImportedTexture;

		public bool clearBuffer;

		public Color clearColor;

		public bool discardBuffer;

		public DepthBits depthBufferBits
		{
			get
			{
				return default(DepthBits);
			}
			set
			{
			}
		}

		public GraphicsFormat colorFormat
		{
			get
			{
				return default(GraphicsFormat);
			}
			set
			{
			}
		}

		private void InitDefaultValues(bool dynamicResolution, bool xrReady)
		{
		}

		public TextureDesc(int width, int height, bool dynamicResolution = false, bool xrReady = false)
		{
			sizeMode = default(TextureSizeMode);
			this.width = 0;
			this.height = 0;
			slices = 0;
			scale = default(Vector2);
			func = null;
			format = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
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
			name = null;
			fastMemoryDesc = default(FastMemoryDesc);
			fallBackToBlackTexture = false;
			disableFallBackToImportedTexture = false;
			clearBuffer = false;
			clearColor = default(Color);
			discardBuffer = false;
		}

		public TextureDesc(Vector2 scale, bool dynamicResolution = false, bool xrReady = false)
		{
			sizeMode = default(TextureSizeMode);
			width = 0;
			height = 0;
			slices = 0;
			this.scale = default(Vector2);
			func = null;
			format = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
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
			name = null;
			fastMemoryDesc = default(FastMemoryDesc);
			fallBackToBlackTexture = false;
			disableFallBackToImportedTexture = false;
			clearBuffer = false;
			clearColor = default(Color);
			discardBuffer = false;
		}

		public TextureDesc(ScaleFunc func, bool dynamicResolution = false, bool xrReady = false)
		{
			sizeMode = default(TextureSizeMode);
			width = 0;
			height = 0;
			slices = 0;
			scale = default(Vector2);
			this.func = null;
			format = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
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
			name = null;
			fastMemoryDesc = default(FastMemoryDesc);
			fallBackToBlackTexture = false;
			disableFallBackToImportedTexture = false;
			clearBuffer = false;
			clearColor = default(Color);
			discardBuffer = false;
		}

		public TextureDesc(TextureDesc input)
		{
			sizeMode = default(TextureSizeMode);
			width = 0;
			height = 0;
			slices = 0;
			scale = default(Vector2);
			func = null;
			format = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
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
			name = null;
			fastMemoryDesc = default(FastMemoryDesc);
			fallBackToBlackTexture = false;
			disableFallBackToImportedTexture = false;
			clearBuffer = false;
			clearColor = default(Color);
			discardBuffer = false;
		}

		public TextureDesc(RenderTextureDescriptor input)
		{
			sizeMode = default(TextureSizeMode);
			width = 0;
			height = 0;
			slices = 0;
			scale = default(Vector2);
			func = null;
			format = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
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
			name = null;
			fastMemoryDesc = default(FastMemoryDesc);
			fallBackToBlackTexture = false;
			disableFallBackToImportedTexture = false;
			clearBuffer = false;
			clearColor = default(Color);
			discardBuffer = false;
		}

		public TextureDesc(RenderTexture input)
		{
			sizeMode = default(TextureSizeMode);
			width = 0;
			height = 0;
			slices = 0;
			scale = default(Vector2);
			func = null;
			format = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
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
			name = null;
			fastMemoryDesc = default(FastMemoryDesc);
			fallBackToBlackTexture = false;
			disableFallBackToImportedTexture = false;
			clearBuffer = false;
			clearColor = default(Color);
			discardBuffer = false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public Vector2Int CalculateFinalDimensions()
		{
			return default(Vector2Int);
		}
	}
}
