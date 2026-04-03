using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Properties;
using UnityEngine;

namespace Unity.Collections
{
	[Serializable]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(FixedBytes32Align8)
	})]
	internal struct FixedList<T, U> : INativeList<T>, IIndexable<T> where T : struct where U : struct
	{
		[SerializeField]
		internal U data;

		internal ushort length
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		internal unsafe readonly byte* buffer
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
		}

		[CreateProperty]
		public int Length
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreateProperty]
		private IEnumerable<T> Elements => null;

		public readonly bool IsEmpty
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		internal readonly int LengthInBytes => 0;

		internal unsafe readonly byte* Buffer
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
		}

		public int Capacity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0;
			}
			set
			{
			}
		}

		public T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(T);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref T ElementAt(int index)
		{
			throw null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public void Add(in T item)
		{
		}

		public unsafe void AddRange(void* ptr, int length)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AddNoResize(in T item)
		{
		}

		public unsafe void AddRangeNoResize(void* ptr, int length)
		{
		}

		public void AddReplicate(in T value, int count)
		{
		}

		public void Clear()
		{
		}

		public void InsertRangeWithBeginEnd(int begin, int end)
		{
		}

		public void InsertRange(int index, int count)
		{
		}

		public void Insert(int index, in T item)
		{
		}

		public void RemoveAtSwapBack(int index)
		{
		}

		public void RemoveRangeSwapBack(int index, int count)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveRange(int index, int count)
		{
		}

		[ExcludeFromBurstCompatTesting("Returns managed array")]
		public T[] ToArray()
		{
			return null;
		}

		public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<T>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[GenerateTestsForBurstCompatibility]
	internal struct FixedList
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		internal static int PaddingBytes<T>() where T : struct
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		internal static int StorageBytes<BUFFER, T>() where BUFFER : struct where T : struct
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		internal static int Capacity<BUFFER, T>() where BUFFER : struct where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		internal static void CheckResize<BUFFER, T>(int newLength) where BUFFER : struct where T : struct
		{
		}
	}
}
