using System.Runtime.CompilerServices;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility]
	internal struct Spinner
	{
		private int m_Lock;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Acquire()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool TryAcquire()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool TryAcquire(bool spin)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Release()
		{
		}
	}
}
