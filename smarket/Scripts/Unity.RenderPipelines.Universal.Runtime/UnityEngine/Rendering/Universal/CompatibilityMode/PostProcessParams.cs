using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal.CompatibilityMode
{
	internal struct PostProcessParams
	{
		public Material blitMaterial;

		public GraphicsFormat requestColorFormat;

		public static PostProcessParams Create()
		{
			return default(PostProcessParams);
		}
	}
}
