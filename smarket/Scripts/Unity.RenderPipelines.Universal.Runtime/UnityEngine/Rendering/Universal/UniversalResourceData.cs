using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public class UniversalResourceData : UniversalResourceDataBase
	{
		private TextureHandle _backBufferColor;

		private TextureHandle _backBufferDepth;

		private TextureHandle _cameraColor;

		private TextureHandle _cameraDepth;

		private TextureHandle _mainShadowsTexture;

		private TextureHandle _additionalShadowsTexture;

		private TextureHandle[] _gBuffer;

		private TextureHandle _cameraOpaqueTexture;

		private TextureHandle _cameraDepthTexture;

		private TextureHandle _cameraNormalsTexture;

		private TextureHandle _motionVectorColor;

		private TextureHandle _motionVectorDepth;

		private TextureHandle _internalColorLut;

		internal TextureHandle _debugScreenColor;

		internal TextureHandle _debugScreenDepth;

		private TextureHandle _afterPostProcessColor;

		private TextureHandle _overlayUITexture;

		private TextureHandle _renderingLayersTexture;

		private TextureHandle[] _dBuffer;

		private TextureHandle _dBufferDepth;

		private TextureHandle _ssaoTexture;

		private TextureHandle _irradianceTexture;

		private TextureHandle _stpDebugView;

		internal ActiveID activeColorID { get; set; }

		public TextureHandle activeColorTexture => default(TextureHandle);

		internal ActiveID activeDepthID { get; set; }

		public TextureHandle activeDepthTexture => default(TextureHandle);

		public bool isActiveTargetBackBuffer => false;

		public TextureHandle backBufferColor
		{
			get
			{
				return default(TextureHandle);
			}
			internal set
			{
			}
		}

		public TextureHandle backBufferDepth
		{
			get
			{
				return default(TextureHandle);
			}
			internal set
			{
			}
		}

		public TextureHandle cameraColor
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		public TextureHandle cameraDepth
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		public TextureHandle mainShadowsTexture
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		public TextureHandle additionalShadowsTexture
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		public TextureHandle[] gBuffer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextureHandle cameraOpaqueTexture
		{
			get
			{
				return default(TextureHandle);
			}
			internal set
			{
			}
		}

		public TextureHandle cameraDepthTexture
		{
			get
			{
				return default(TextureHandle);
			}
			internal set
			{
			}
		}

		public TextureHandle cameraNormalsTexture
		{
			get
			{
				return default(TextureHandle);
			}
			internal set
			{
			}
		}

		public TextureHandle motionVectorColor
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		public TextureHandle motionVectorDepth
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		public TextureHandle internalColorLut
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		internal TextureHandle debugScreenColor
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		internal TextureHandle debugScreenDepth
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		public TextureHandle afterPostProcessColor
		{
			get
			{
				return default(TextureHandle);
			}
			internal set
			{
			}
		}

		public TextureHandle overlayUITexture
		{
			get
			{
				return default(TextureHandle);
			}
			internal set
			{
			}
		}

		public TextureHandle renderingLayersTexture
		{
			get
			{
				return default(TextureHandle);
			}
			internal set
			{
			}
		}

		public TextureHandle[] dBuffer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextureHandle dBufferDepth
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		public TextureHandle ssaoTexture
		{
			get
			{
				return default(TextureHandle);
			}
			internal set
			{
			}
		}

		internal TextureHandle irradianceTexture
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		internal TextureHandle stpDebugView
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		public void SwitchActiveTexturesToBackbuffer()
		{
		}

		public override void Reset()
		{
		}
	}
}
