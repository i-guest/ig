using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections
{
	[NativeContainer]
	[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
	[GenerateTestsForBurstCompatibility]
	public struct NativeBitArray : INativeDisposable, IDisposable
	{
		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct ReadOnly
		{
			[NativeDisableUnsafePtrRestriction]
			internal UnsafeBitArray.ReadOnly m_BitArray;

			public readonly bool IsCreated => false;

			public readonly bool IsEmpty => false;

			public readonly int Length => 0;

			internal ReadOnly(ref NativeBitArray data)
			{
				m_BitArray = default(UnsafeBitArray.ReadOnly);
			}

			public readonly ulong GetBits(int pos, int numBits = 1)
			{
				return 0uL;
			}

			public readonly bool IsSet(int pos)
			{
				return false;
			}

			public readonly int Find(int pos, int numBits)
			{
				return 0;
			}

			public readonly int Find(int pos, int count, int numBits)
			{
				return 0;
			}

			public readonly bool TestNone(int pos, int numBits = 1)
			{
				return false;
			}

			public readonly bool TestAny(int pos, int numBits = 1)
			{
				return false;
			}

			public readonly bool TestAll(int pos, int numBits = 1)
			{
				return false;
			}

			public readonly int CountBits(int pos, int numBits = 1)
			{
				return 0;
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			private readonly void CheckRead()
			{
			}
		}

		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeBitArray* m_BitArray;

		internal AllocatorManager.AllocatorHandle m_Allocator;

		public readonly bool IsCreated => false;

		public readonly bool IsEmpty => false;

		public readonly int Length
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		public readonly int Capacity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		public unsafe NativeBitArray(int numBits, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
			m_BitArray = null;
			m_Allocator = default(AllocatorManager.AllocatorHandle);
		}

		public void Resize(int numBits, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
		{
		}

		public void SetCapacity(int capacityInBits)
		{
		}

		public void TrimExcess()
		{
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		public void Clear()
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public NativeArray<T> AsNativeArray<T>() where T : struct
		{
			return default(NativeArray<T>);
		}

		public void Set(int pos, bool value)
		{
		}

		public void SetBits(int pos, bool value, int numBits)
		{
		}

		public void SetBits(int pos, ulong value, int numBits = 1)
		{
		}

		public ulong GetBits(int pos, int numBits = 1)
		{
			return 0uL;
		}

		public bool IsSet(int pos)
		{
			return false;
		}

		public void Copy(int dstPos, int srcPos, int numBits)
		{
		}

		public void Copy(int dstPos, ref NativeBitArray srcBitArray, int srcPos, int numBits)
		{
		}

		public int Find(int pos, int numBits)
		{
			return 0;
		}

		public int Find(int pos, int count, int numBits)
		{
			return 0;
		}

		public bool TestNone(int pos, int numBits = 1)
		{
			return false;
		}

		public bool TestAny(int pos, int numBits = 1)
		{
			return false;
		}

		public bool TestAll(int pos, int numBits = 1)
		{
			return false;
		}

		public int CountBits(int pos, int numBits = 1)
		{
			return 0;
		}

		public ReadOnly AsReadOnly()
		{
			return default(ReadOnly);
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private readonly void CheckRead()
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckReadBounds<T>() where T : struct
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckWrite()
		{
		}
	}
}
