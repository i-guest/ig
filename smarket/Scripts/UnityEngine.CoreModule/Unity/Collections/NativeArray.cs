using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace Unity.Collections
{
	[NativeContainerSupportsMinMaxWriteRestriction]
	[DebuggerTypeProxy(typeof(NativeArrayDebugView<>))]
	[NativeContainer]
	[DebuggerDisplay("Length = {m_Length}")]
	[NativeContainerSupportsDeferredConvertListToArray]
	[NativeContainerSupportsDeallocateOnJobCompletion]
	public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> where T : struct
	{
		[ExcludeFromDocs]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			private NativeArray<T> m_Array;

			private int m_Index;

			private T value;

			public T Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return default(T);
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return null;
				}
			}

			public Enumerator(ref NativeArray<T> array)
			{
				m_Array = default(NativeArray<T>);
				m_Index = 0;
				value = default(T);
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

		[NativeContainerIsReadOnly]
		[NativeContainer]
		[DebuggerTypeProxy(typeof(NativeArrayReadOnlyDebugView<>))]
		[DebuggerDisplay("Length = {Length}")]
		public struct ReadOnly : IEnumerable<T>, IEnumerable
		{
			[ExcludeFromDocs]
			public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
			{
				private ReadOnly m_Array;

				private int m_Index;

				private T value;

				public T Current
				{
					[MethodImpl(MethodImplOptions.AggressiveInlining)]
					get
					{
						return default(T);
					}
				}

				object IEnumerator.Current => null;

				public Enumerator(in ReadOnly array)
				{
					m_Array = default(ReadOnly);
					m_Index = 0;
					value = default(T);
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

			[NativeDisableUnsafePtrRestriction]
			internal unsafe void* m_Buffer;

			internal int m_Length;

			public int Length
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return 0;
				}
			}

			public T this[int index]
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return default(T);
				}
			}

			internal unsafe ReadOnly(void* buffer, int length)
			{
				m_Buffer = null;
				m_Length = 0;
			}

			public ref T UnsafeElementAt(int index)
			{
				throw null;
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			public readonly ReadOnlySpan<T> AsReadOnlySpan()
			{
				return default(ReadOnlySpan<T>);
			}

			public static implicit operator ReadOnlySpan<T>(in ReadOnly source)
			{
				return default(ReadOnlySpan<T>);
			}
		}

		[NativeDisableUnsafePtrRestriction]
		[VisibleToOtherModules(new string[] { "UnityEngine.ContentLoadModule", "UnityEngine.TilemapModule" })]
		internal unsafe void* m_Buffer;

		internal int m_Length;

		internal Allocator m_AllocatorLabel;

		public int Length
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		public T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(T);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[WriteAccessRequired]
			set
			{
			}
		}

		public bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public unsafe NativeArray(int length, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
			m_Buffer = null;
			m_Length = 0;
			m_AllocatorLabel = default(Allocator);
		}

		public unsafe NativeArray(int length, MemoryLabel label, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
			m_Buffer = null;
			m_Length = 0;
			m_AllocatorLabel = default(Allocator);
		}

		public unsafe NativeArray(T[] array, Allocator allocator)
		{
			m_Buffer = null;
			m_Length = 0;
			m_AllocatorLabel = default(Allocator);
		}

		public unsafe NativeArray(NativeArray<T> array, Allocator allocator)
		{
			m_Buffer = null;
			m_Length = 0;
			m_AllocatorLabel = default(Allocator);
		}

		private static void Allocate(int length, Allocator allocator, MemoryLabel label, out NativeArray<T> array)
		{
			array = default(NativeArray<T>);
		}

		[WriteAccessRequired]
		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		[WriteAccessRequired]
		public void CopyFrom(T[] array)
		{
		}

		[WriteAccessRequired]
		public void CopyFrom(NativeArray<T> array)
		{
		}

		public void CopyTo(T[] array)
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public bool Equals(NativeArray<T> other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(NativeArray<T> left, NativeArray<T> right)
		{
			return false;
		}

		public static void Copy(NativeArray<T> src, NativeArray<T> dst)
		{
		}

		public static void Copy(T[] src, NativeArray<T> dst)
		{
		}

		public static void Copy(NativeArray<T> src, T[] dst)
		{
		}

		public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length)
		{
		}

		public static void Copy(NativeArray<T> src, T[] dst, int length)
		{
		}

		public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
		}

		public static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length)
		{
		}

		private static void CopySafe(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
		}

		private static void CopySafe(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
		}

		private static void CopySafe(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length)
		{
		}

		private NativeArray<U> InternalReinterpret<U>(int length) where U : struct
		{
			return default(NativeArray<U>);
		}

		public NativeArray<U> Reinterpret<U>() where U : struct
		{
			return default(NativeArray<U>);
		}

		public NativeArray<U> Reinterpret<U>(int expectedTypeSize) where U : struct
		{
			return default(NativeArray<U>);
		}

		public NativeArray<T> GetSubArray(int start, int length)
		{
			return default(NativeArray<T>);
		}

		public ReadOnly AsReadOnly()
		{
			return default(ReadOnly);
		}

		[WriteAccessRequired]
		public readonly Span<T> AsSpan()
		{
			return default(Span<T>);
		}

		public readonly ReadOnlySpan<T> AsReadOnlySpan()
		{
			return default(ReadOnlySpan<T>);
		}

		public static implicit operator Span<T>(in NativeArray<T> source)
		{
			return default(Span<T>);
		}

		public static implicit operator ReadOnlySpan<T>(in NativeArray<T> source)
		{
			return default(ReadOnlySpan<T>);
		}
	}
}
