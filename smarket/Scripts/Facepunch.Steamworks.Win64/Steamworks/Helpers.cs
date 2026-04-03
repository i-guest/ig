using System;
using System.Collections.Generic;

namespace Steamworks
{
	internal static class Helpers
	{
		internal struct Memory : IDisposable
		{
			private const int MaxBagSize = 4;

			private static readonly Queue<IntPtr> BufferBag;

			public IntPtr Ptr { get; private set; }

			public static implicit operator IntPtr(in Memory m)
			{
				return (IntPtr)0;
			}

			internal static Memory Take()
			{
				return default(Memory);
			}

			public void Dispose()
			{
			}
		}

		public const int MemoryBufferSize = 32768;

		private static byte[][] BufferPool;

		private static int BufferPoolIndex;

		public static Memory TakeMemory()
		{
			return default(Memory);
		}

		public static byte[] TakeBuffer(int minSize)
		{
			return null;
		}

		internal static string MemoryToString(IntPtr ptr)
		{
			return null;
		}

		internal static string BuildVersionString(params string[] interfaceVersions)
		{
			return null;
		}
	}
}
