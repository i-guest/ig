using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;
using UnityEngine;

namespace Unity.Collections
{
	[Serializable]
	[DebuggerTypeProxy(typeof(FixedList4096BytesDebugView<>))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct FixedList4096Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
	{
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			private FixedList4096Bytes<T> m_List;

			private int m_Index;

			public T Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return default(T);
				}
			}

			object IEnumerator.Current => null;

			public Enumerator(ref FixedList4096Bytes<T> list)
			{
				m_List = default(FixedList4096Bytes<T>);
				m_Index = 0;
			}

			public void Dispose()
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		[SerializeField]
		internal FixedBytes4096Align8 data;

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

		internal int LengthInBytes => 0;

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

		public static bool operator ==(in FixedList4096Bytes<T> a, in FixedList32Bytes<T> b)
		{
			return false;
		}

		public static bool operator !=(in FixedList4096Bytes<T> a, in FixedList32Bytes<T> b)
		{
			return false;
		}

		public int CompareTo(FixedList32Bytes<T> other)
		{
			return 0;
		}

		public bool Equals(FixedList32Bytes<T> other)
		{
			return false;
		}

		public FixedList4096Bytes(in FixedList32Bytes<T> other)
		{
			data = default(FixedBytes4096Align8);
		}

		internal int Initialize(in FixedList32Bytes<T> other)
		{
			return 0;
		}

		public static implicit operator FixedList4096Bytes<T>(in FixedList32Bytes<T> other)
		{
			return default(FixedList4096Bytes<T>);
		}

		public static bool operator ==(in FixedList4096Bytes<T> a, in FixedList64Bytes<T> b)
		{
			return false;
		}

		public static bool operator !=(in FixedList4096Bytes<T> a, in FixedList64Bytes<T> b)
		{
			return false;
		}

		public int CompareTo(FixedList64Bytes<T> other)
		{
			return 0;
		}

		public bool Equals(FixedList64Bytes<T> other)
		{
			return false;
		}

		public FixedList4096Bytes(in FixedList64Bytes<T> other)
		{
			data = default(FixedBytes4096Align8);
		}

		internal int Initialize(in FixedList64Bytes<T> other)
		{
			return 0;
		}

		public static implicit operator FixedList4096Bytes<T>(in FixedList64Bytes<T> other)
		{
			return default(FixedList4096Bytes<T>);
		}

		public static bool operator ==(in FixedList4096Bytes<T> a, in FixedList128Bytes<T> b)
		{
			return false;
		}

		public static bool operator !=(in FixedList4096Bytes<T> a, in FixedList128Bytes<T> b)
		{
			return false;
		}

		public int CompareTo(FixedList128Bytes<T> other)
		{
			return 0;
		}

		public bool Equals(FixedList128Bytes<T> other)
		{
			return false;
		}

		public FixedList4096Bytes(in FixedList128Bytes<T> other)
		{
			data = default(FixedBytes4096Align8);
		}

		internal int Initialize(in FixedList128Bytes<T> other)
		{
			return 0;
		}

		public static implicit operator FixedList4096Bytes<T>(in FixedList128Bytes<T> other)
		{
			return default(FixedList4096Bytes<T>);
		}

		public static bool operator ==(in FixedList4096Bytes<T> a, in FixedList512Bytes<T> b)
		{
			return false;
		}

		public static bool operator !=(in FixedList4096Bytes<T> a, in FixedList512Bytes<T> b)
		{
			return false;
		}

		public int CompareTo(FixedList512Bytes<T> other)
		{
			return 0;
		}

		public bool Equals(FixedList512Bytes<T> other)
		{
			return false;
		}

		public FixedList4096Bytes(in FixedList512Bytes<T> other)
		{
			data = default(FixedBytes4096Align8);
		}

		internal int Initialize(in FixedList512Bytes<T> other)
		{
			return 0;
		}

		public static implicit operator FixedList4096Bytes<T>(in FixedList512Bytes<T> other)
		{
			return default(FixedList4096Bytes<T>);
		}

		public static bool operator ==(in FixedList4096Bytes<T> a, in FixedList4096Bytes<T> b)
		{
			return false;
		}

		public static bool operator !=(in FixedList4096Bytes<T> a, in FixedList4096Bytes<T> b)
		{
			return false;
		}

		public int CompareTo(FixedList4096Bytes<T> other)
		{
			return 0;
		}

		public bool Equals(FixedList4096Bytes<T> other)
		{
			return false;
		}

		[ExcludeFromBurstCompatTesting("Takes managed object")]
		public override bool Equals(object obj)
		{
			return false;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
}
