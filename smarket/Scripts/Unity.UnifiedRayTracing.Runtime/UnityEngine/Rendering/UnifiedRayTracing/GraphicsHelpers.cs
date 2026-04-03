using Unity.Mathematics;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal static class GraphicsHelpers
	{
		public static long MaxGraphicsBufferSizeInBytes => 0L;

		public static float MaxGraphicsBufferSizeInGigaBytes => 0f;

		public static void CopyBuffer(ComputeShader copyShader, CommandBuffer cmd, GraphicsBuffer src, int srcOffsetInDWords, GraphicsBuffer dst, int dstOffsetInDwords, int sizeInDWords)
		{
		}

		public static void CopyBuffer(ComputeShader copyShader, GraphicsBuffer src, int srcOffsetInDWords, GraphicsBuffer dst, int dstOffsetInDwords, int sizeInDwords)
		{
		}

		public static bool ReallocateBuffer(ComputeShader copyShader, int oldCapacity, int newCapacity, int elementSizeInBytes, ref GraphicsBuffer buffer)
		{
			return false;
		}

		public static int DivUp(int x, int y)
		{
			return 0;
		}

		public static int DivUp(int x, uint y)
		{
			return 0;
		}

		public static uint DivUp(uint x, uint y)
		{
			return 0u;
		}

		public static uint3 DivUp(uint3 x, uint3 y)
		{
			return default(uint3);
		}

		public static void Flush(CommandBuffer cmd)
		{
		}
	}
}
