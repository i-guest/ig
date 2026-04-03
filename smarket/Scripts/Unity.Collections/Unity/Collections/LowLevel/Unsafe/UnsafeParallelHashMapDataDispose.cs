namespace Unity.Collections.LowLevel.Unsafe
{
	[NativeContainer]
	[GenerateTestsForBurstCompatibility]
	internal struct UnsafeParallelHashMapDataDispose
	{
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer;

		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

		public void Dispose()
		{
		}
	}
}
