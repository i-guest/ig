using System.Runtime.CompilerServices;

namespace Unity.Collections.LowLevel.Unsafe
{
	internal static class UnsafeTextExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref UnsafeList<byte> AsUnsafeListOfBytes(this ref UnsafeText text)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UnsafeList<byte> AsUnsafeListOfBytesRO(this UnsafeText text)
		{
			return default(UnsafeList<byte>);
		}
	}
}
