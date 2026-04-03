using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class Universal2DResourceData : UniversalResourceDataBase
	{
		private TextureHandle[][] _lightTextures;

		private TextureHandle[] _cameraNormalsTexture;

		private TextureHandle _normalsDepth;

		private TextureHandle[][] _shadowTextures;

		private TextureHandle _shadowDepth;

		private TextureHandle _upscaleTexture;

		private TextureHandle _cameraSortingLayerTexture;

		internal TextureHandle[][] lightTextures
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal TextureHandle[] normalsTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal TextureHandle normalsDepth
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		internal TextureHandle[][] shadowTextures
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal TextureHandle shadowDepth
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		internal TextureHandle upscaleTexture
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		internal TextureHandle cameraSortingLayerTexture
		{
			get
			{
				return default(TextureHandle);
			}
			set
			{
			}
		}

		private TextureHandle[][] CheckAndGetTextureHandle(ref TextureHandle[][] handle)
		{
			return null;
		}

		private void CheckAndSetTextureHandle(ref TextureHandle[][] handle, TextureHandle[][] newHandle)
		{
		}

		public override void Reset()
		{
		}
	}
}
