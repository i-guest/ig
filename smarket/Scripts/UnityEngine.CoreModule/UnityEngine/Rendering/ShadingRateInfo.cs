using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Graphics/ShadingRateInfo.h")]
	public static class ShadingRateInfo
	{
		public static bool supportsPerImageTile => false;

		public static bool supportsPerDrawCall => false;

		public static Vector2Int imageTileSize => default(Vector2Int);

		public static ShadingRateFragmentSize[] availableFragmentSizes => null;

		[FreeFunction("ShadingRateInfo::QueryNativeValue")]
		public static byte QueryNativeValue(ShadingRateFragmentSize fragmentSize)
		{
			return 0;
		}

		[FreeFunction("ShadingRateInfo::SupportsPerImageTile")]
		private static bool SupportsPerImageTile()
		{
			return false;
		}

		[FreeFunction("ShadingRateInfo::SupportsPerDrawCall")]
		private static bool SupportsPerDrawCall()
		{
			return false;
		}

		[FreeFunction("ShadingRateInfo::GetImageTileSize")]
		private static Vector2Int GetImageTileSize()
		{
			return default(Vector2Int);
		}

		[FreeFunction("ShadingRateInfo::GetAvailableFragmentSizes")]
		private static ShadingRateFragmentSize[] GetAvailableFragmentSizes()
		{
			return null;
		}

		private static void GetImageTileSize_Injected(out Vector2Int ret)
		{
			ret = default(Vector2Int);
		}

		private static void GetAvailableFragmentSizes_Injected(out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}
	}
}
