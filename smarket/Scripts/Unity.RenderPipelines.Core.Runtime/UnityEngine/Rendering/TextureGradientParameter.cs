using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class TextureGradientParameter : VolumeParameter<TextureGradient>
	{
		public TextureGradientParameter(TextureGradient value, bool overrideState = false)
		{
		}

		public override void Release()
		{
		}
	}
}
