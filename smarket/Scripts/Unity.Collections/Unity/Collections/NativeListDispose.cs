using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	[NativeContainer]
	[GenerateTestsForBurstCompatibility]
	internal struct NativeListDispose
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe UntypedUnsafeList* m_ListData;

		public void Dispose()
		{
		}
	}
}
