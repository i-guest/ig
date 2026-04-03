namespace UnityEngine.UIElements.UIR
{
	internal static class RenderTreeAtlas
	{
		public struct AtlasBlock
		{
			public int width;

			public int height;

			public RectInt rect;

			public Rect uvRect;

			public RenderTexture texture;

			public AtlasBlock(int w, int h, RectInt r, Rect uv)
			{
				width = 0;
				height = 0;
				rect = default(RectInt);
				uvRect = default(Rect);
				texture = null;
			}
		}

		public static bool ReserveSize(int width, int height, out AtlasBlock block)
		{
			block = default(AtlasBlock);
			return false;
		}

		public static bool CreateTextureForAtlasBlock(ref AtlasBlock block, bool forceGammaRendering, out bool allocatedNewTexture)
		{
			allocatedNewTexture = default(bool);
			return false;
		}
	}
}
