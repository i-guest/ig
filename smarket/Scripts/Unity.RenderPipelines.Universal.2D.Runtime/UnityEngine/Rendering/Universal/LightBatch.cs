using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	internal class LightBatch
	{
		private static readonly ProfilingSampler profilingDrawBatched;

		private static readonly int k_BufferOffset;

		private static int sBatchIndexCounter;

		private int[] subsets;

		private Mesh[] lightMeshes;

		private Matrix4x4[] matrices;

		private LightBuffer[] lightBuffer;

		private Light2D cachedLight;

		private Material cachedMaterial;

		private int hashCode;

		private int lightCount;

		private int maxIndex;

		private int batchCount;

		private int activeCount;

		private static int batchLightMod => 0;

		private static float batchRunningIndex => 0f;

		public static bool isBatchingSupported => false;

		internal NativeArray<PerLight2D> nativeBuffer => default(NativeArray<PerLight2D>);

		internal GraphicsBuffer graphicsBuffer => null;

		internal NativeArray<int> lightMarker => default(NativeArray<int>);

		internal static int batchSlotIndex => 0;

		internal PerLight2D GetLight(int index)
		{
			return default(PerLight2D);
		}

		internal void SetLight(int index, PerLight2D light)
		{
		}

		internal static float GetBatchColor()
		{
			return 0f;
		}

		internal static int GetBatchSlotIndex(float channelColor)
		{
			return 0;
		}

		private static int Hash(Light2D light, Material material)
		{
			return 0;
		}

		private void Validate()
		{
		}

		private void OnAssemblyReload()
		{
		}

		private void ResetInternals()
		{
		}

		private void SetBuffer()
		{
		}

		internal int SlotIndex(int x)
		{
			return 0;
		}

		internal void Reset()
		{
		}

		internal bool CanBatch(Light2D light, Material material, int index, out int lightHash)
		{
			lightHash = default(int);
			return false;
		}

		internal bool AddBatch(Light2D light, Material material, Matrix4x4 mat, Mesh mesh, int subset, int lightHash, int index)
		{
			return false;
		}

		internal void Flush(RasterCommandBuffer cmd)
		{
		}
	}
}
