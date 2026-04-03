namespace UnityEngine.Rendering.Universal
{
	internal static class LayerUtility
	{
		private static LayerBatch[] s_LayerBatches;

		public static uint maxTextureCount { get; private set; }

		public static void InitializeBudget(uint maxTextureCount)
		{
		}

		private static bool CanBatchLightsInLayer(int layerIndex1, int layerIndex2, SortingLayer[] sortingLayers, ILight2DCullResult lightCullResult)
		{
			return false;
		}

		private static bool CanBatchCameraSortingLayer(int startLayerIndex, SortingLayer[] sortingLayers, Renderer2DData rendererData)
		{
			return false;
		}

		private static int FindUpperBoundInBatch(int startLayerIndex, SortingLayer[] sortingLayers, Renderer2DData rendererData)
		{
			return 0;
		}

		private static void InitializeBatchInfos(SortingLayer[] cachedSortingLayers)
		{
		}

		public static LayerBatch[] CalculateBatches(Renderer2DData rendererData, out int batchCount)
		{
			batchCount = default(int);
			return null;
		}

		public static void GetFilterSettings(Renderer2DData rendererData, ref LayerBatch layerBatch, out FilteringSettings filterSettings)
		{
			filterSettings = default(FilteringSettings);
		}

		private static void SetupActiveBlendStyles()
		{
		}
	}
}
