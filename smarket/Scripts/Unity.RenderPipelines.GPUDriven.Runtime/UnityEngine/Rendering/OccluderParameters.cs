using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	public struct OccluderParameters
	{
		public int viewInstanceID;

		public int subviewCount;

		public TextureHandle depthTexture;

		public Vector2Int depthSize;

		public bool depthIsArray;

		public OccluderParameters(int viewInstanceID)
		{
			this.viewInstanceID = 0;
			subviewCount = 0;
			depthTexture = default(TextureHandle);
			depthSize = default(Vector2Int);
			depthIsArray = false;
		}
	}
}
