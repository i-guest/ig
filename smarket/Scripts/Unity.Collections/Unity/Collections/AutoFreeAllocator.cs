using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;

namespace Unity.Collections
{
	[BurstCompile]
	internal struct AutoFreeAllocator : AllocatorManager.IAllocator, IDisposable
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate int Try_000000E3_0024PostfixBurstDelegate(IntPtr state, ref AllocatorManager.Block block);

		internal static class Try_000000E3_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static int Invoke(IntPtr state, ref AllocatorManager.Block block)
			{
				return 0;
			}
		}

		private ArrayOfArrays<IntPtr> m_allocated;

		private ArrayOfArrays<IntPtr> m_tofree;

		private AllocatorManager.AllocatorHandle m_handle;

		private AllocatorManager.AllocatorHandle m_backingAllocatorHandle;

		public AllocatorManager.TryFunction Function => null;

		public AllocatorManager.AllocatorHandle Handle
		{
			get
			{
				return default(AllocatorManager.AllocatorHandle);
			}
			set
			{
			}
		}

		public Allocator ToAllocator => default(Allocator);

		public bool IsCustomAllocator => false;

		public bool IsAutoDispose => false;

		public void Update()
		{
		}

		public void Initialize(AllocatorManager.AllocatorHandle backingAllocatorHandle)
		{
		}

		public void FreeAll()
		{
		}

		public void Dispose()
		{
		}

		public int Try(ref AllocatorManager.Block block)
		{
			return 0;
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		internal static int Try(IntPtr state, ref AllocatorManager.Block block)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		internal static int Try_0024BurstManaged(IntPtr state, ref AllocatorManager.Block block)
		{
			return 0;
		}
	}
}
