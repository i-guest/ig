using System.Runtime.CompilerServices;

namespace System.Security.Cryptography
{
	public static class CryptographicOperations
	{
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static bool FixedTimeEquals(ReadOnlySpan<byte> left, ReadOnlySpan<byte> right)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void ZeroMemory(Span<byte> buffer)
		{
		}
	}
}
