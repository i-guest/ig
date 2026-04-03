using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	[NativeContainer]
	[GenerateTestsForBurstCompatibility]
	internal struct NativeTextDispose
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeText* m_TextData;

		public void Dispose()
		{
		}
	}
}
