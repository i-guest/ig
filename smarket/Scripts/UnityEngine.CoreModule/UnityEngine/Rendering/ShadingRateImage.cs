using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Graphics/ShadingRateImage.h")]
	public static class ShadingRateImage
	{
		[FreeFunction("ShadingRateImage::GetAllocSizeInternal")]
		internal static void GetAllocSizeInternal(int pixelWidth, int pixelHeight, out int tileWidth, out int tileHeight)
		{
			tileWidth = default(int);
			tileHeight = default(int);
		}

		public static Vector2Int GetAllocTileSize(Vector2Int pixelSize)
		{
			return default(Vector2Int);
		}

		public static Vector2Int GetAllocTileSize(int pixelWidth, int pixelHeight)
		{
			return default(Vector2Int);
		}
	}
}
