using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal static class BufferManager
	{
		private sealed class ReferenceCounter
		{
			private int _count;

			public IntPtr Pointer { get; private set; }

			public int Size { get; private set; }

			public void Set(IntPtr ptr, int size, int referenceCount)
			{
			}

			public bool Decrement()
			{
				return false;
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private unsafe delegate void FreeFn(NetMsg* msg);

		private static readonly Stack<ReferenceCounter> ReferenceCounterPool;

		private static readonly Dictionary<int, Stack<IntPtr>> BufferPools;

		private static readonly Dictionary<IntPtr, ReferenceCounter> ReferenceCounters;

		private static readonly FreeFn FreeFunctionPin;

		public static readonly IntPtr FreeFunctionPointer;

		private const int Bucket512 = 512;

		private const int Bucket1Kb = 1024;

		private const int Bucket4Kb = 4096;

		private const int Bucket16Kb = 16384;

		private const int Bucket64Kb = 65536;

		private const int Bucket256Kb = 262144;

		public static IntPtr Get(int size, int referenceCount)
		{
			return (IntPtr)0;
		}

		[MonoPInvokeCallback]
		private unsafe static void Free(NetMsg* msg)
		{
		}

		private static ReferenceCounter AllocateReferenceCounter(IntPtr ptr, int size, int referenceCount)
		{
			return null;
		}

		private static void FreeReferenceCounter(ReferenceCounter counter)
		{
		}

		private static void AllocateBuffer(int minimumSize, out IntPtr ptr, out int size)
		{
			ptr = default(IntPtr);
			size = default(int);
		}

		private static void FreeBuffer(IntPtr ptr, int size)
		{
		}

		private static int GetBucketSize(int size)
		{
			return 0;
		}

		private static int GetBucketLimit(int size)
		{
			return 0;
		}
	}
}
