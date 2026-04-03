using System;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class TextureGradient : IDisposable
	{
		[SerializeField]
		private Gradient m_Gradient;

		private Texture2D m_Texture;

		private int m_RequestedTextureSize;

		private bool m_IsTextureDirty;

		private bool m_Precise;

		[SerializeField]
		[HideInInspector]
		public GradientMode mode;

		[SerializeField]
		[HideInInspector]
		public ColorSpace colorSpace;

		[field: SerializeField]
		[field: HideInInspector]
		public int textureSize { get; private set; }

		[HideInInspector]
		public GradientColorKey[] colorKeys => null;

		[HideInInspector]
		public GradientAlphaKey[] alphaKeys => null;

		public TextureGradient(Gradient baseCurve)
		{
		}

		public TextureGradient(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys, GradientMode mode = GradientMode.PerceptualBlend, ColorSpace colorSpace = ColorSpace.Uninitialized, int requestedTextureSize = -1, bool precise = false)
		{
		}

		private void Rebuild(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys, GradientMode mode, ColorSpace colorSpace, int requestedTextureSize, bool precise)
		{
		}

		public void Dispose()
		{
		}

		public void Release()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetDirty()
		{
		}

		private static GraphicsFormat GetTextureFormat()
		{
			return default(GraphicsFormat);
		}

		public Texture2D GetTexture()
		{
			return null;
		}

		public Color Evaluate(float time)
		{
			return default(Color);
		}

		public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys, GradientMode mode, ColorSpace colorSpace)
		{
		}
	}
}
