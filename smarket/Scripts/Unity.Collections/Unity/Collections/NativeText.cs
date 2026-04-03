using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Properties;

namespace Unity.Collections
{
	[NativeContainer]
	[DebuggerDisplay("Length = {Length}")]
	[GenerateTestsForBurstCompatibility]
	public struct NativeText : INativeList<byte>, IIndexable<byte>, INativeDisposable, IDisposable, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<NativeText>, IEquatable<NativeText>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
	{
		public struct Enumerator : IEnumerator<Unicode.Rune>, IEnumerator, IDisposable
		{
			private ReadOnly target;

			private int offset;

			private Unicode.Rune current;

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return null;
				}
			}

			public Unicode.Rune Current => default(Unicode.Rune);

			public Enumerator(NativeText source)
			{
				target = default(ReadOnly);
				offset = 0;
				current = default(Unicode.Rune);
			}

			public Enumerator(ReadOnly source)
			{
				target = default(ReadOnly);
				offset = 0;
				current = default(Unicode.Rune);
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

		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct ReadOnly : INativeList<byte>, IIndexable<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<NativeText>, IEquatable<NativeText>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
		{
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeText* m_Data;

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

			public bool IsEmpty
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				readonly get
				{
					return false;
				}
				set
				{
				}
			}

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

			public byte this[int index]
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

			[CreateProperty]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[ExcludeFromBurstCompatTesting("Returns managed string")]
			public string Value => null;

			internal unsafe ReadOnly(UnsafeText* text)
			{
				m_Data = null;
			}

			public void Clear()
			{
			}

			public ref byte ElementAt(int index)
			{
				throw null;
			}

			public unsafe byte* GetUnsafePtr()
			{
				return null;
			}

			public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory)
			{
				return false;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			internal unsafe static void CheckNull(void* dataPtr)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			private readonly void CheckRead()
			{
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private void ErrorWrite()
			{
			}

			[ExcludeFromBurstCompatTesting("Takes managed string")]
			public int CompareTo(string other)
			{
				return 0;
			}

			[ExcludeFromBurstCompatTesting("Takes managed string")]
			public bool Equals(string other)
			{
				return false;
			}

			public int CompareTo(ReadOnly other)
			{
				return 0;
			}

			public bool Equals(ReadOnly other)
			{
				return false;
			}

			public int CompareTo(NativeText other)
			{
				return 0;
			}

			public bool Equals(NativeText other)
			{
				return false;
			}

			public int CompareTo(FixedString32Bytes other)
			{
				return 0;
			}

			public static bool operator ==(in ReadOnly a, in FixedString32Bytes b)
			{
				return false;
			}

			public static bool operator !=(in ReadOnly a, in FixedString32Bytes b)
			{
				return false;
			}

			public bool Equals(FixedString32Bytes other)
			{
				return false;
			}

			public int CompareTo(FixedString64Bytes other)
			{
				return 0;
			}

			public static bool operator ==(in ReadOnly a, in FixedString64Bytes b)
			{
				return false;
			}

			public static bool operator !=(in ReadOnly a, in FixedString64Bytes b)
			{
				return false;
			}

			public bool Equals(FixedString64Bytes other)
			{
				return false;
			}

			public int CompareTo(FixedString128Bytes other)
			{
				return 0;
			}

			public static bool operator ==(in ReadOnly a, in FixedString128Bytes b)
			{
				return false;
			}

			public static bool operator !=(in ReadOnly a, in FixedString128Bytes b)
			{
				return false;
			}

			public bool Equals(FixedString128Bytes other)
			{
				return false;
			}

			public int CompareTo(FixedString512Bytes other)
			{
				return 0;
			}

			public static bool operator ==(in ReadOnly a, in FixedString512Bytes b)
			{
				return false;
			}

			public static bool operator !=(in ReadOnly a, in FixedString512Bytes b)
			{
				return false;
			}

			public bool Equals(FixedString512Bytes other)
			{
				return false;
			}

			public int CompareTo(FixedString4096Bytes other)
			{
				return 0;
			}

			public static bool operator ==(in ReadOnly a, in FixedString4096Bytes b)
			{
				return false;
			}

			public static bool operator !=(in ReadOnly a, in FixedString4096Bytes b)
			{
				return false;
			}

			public bool Equals(FixedString4096Bytes other)
			{
				return false;
			}

			[ExcludeFromBurstCompatTesting("Returns managed string")]
			public override string ToString()
			{
				return null;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			[ExcludeFromBurstCompatTesting("Takes managed object")]
			public override bool Equals(object other)
			{
				return false;
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}
		}

		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeText* m_Data;

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

		public readonly bool IsEmpty
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public readonly bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public byte this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		[CreateProperty]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ExcludeFromBurstCompatTesting("Returns managed string")]
		public string Value => null;

		[ExcludeFromBurstCompatTesting("Takes managed string")]
		public unsafe NativeText(string source, Allocator allocator)
		{
			m_Data = null;
		}

		[ExcludeFromBurstCompatTesting("Takes managed string")]
		public unsafe NativeText(string source, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(int capacity, Allocator allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(int capacity, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(Allocator allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(in FixedString32Bytes source, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(in FixedString32Bytes source, Allocator allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(in FixedString64Bytes source, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(in FixedString64Bytes source, Allocator allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(in FixedString128Bytes source, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(in FixedString128Bytes source, Allocator allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(in FixedString512Bytes source, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(in FixedString512Bytes source, Allocator allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(in FixedString4096Bytes source, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = null;
		}

		public unsafe NativeText(in FixedString4096Bytes source, Allocator allocator)
		{
			m_Data = null;
		}

		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory)
		{
			return false;
		}

		public unsafe byte* GetUnsafePtr()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref byte ElementAt(int index)
		{
			throw null;
		}

		public void Clear()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Add(in byte value)
		{
		}

		public int CompareTo(NativeText other)
		{
			return 0;
		}

		public bool Equals(NativeText other)
		{
			return false;
		}

		public int CompareTo(ReadOnly other)
		{
			return 0;
		}

		public bool Equals(ReadOnly other)
		{
			return false;
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[ExcludeFromBurstCompatTesting("Takes managed string")]
		public int CompareTo(string other)
		{
			return 0;
		}

		[ExcludeFromBurstCompatTesting("Takes managed string")]
		public bool Equals(string other)
		{
			return false;
		}

		public int CompareTo(FixedString32Bytes other)
		{
			return 0;
		}

		public static bool operator ==(in NativeText a, in FixedString32Bytes b)
		{
			return false;
		}

		public static bool operator !=(in NativeText a, in FixedString32Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString32Bytes other)
		{
			return false;
		}

		public int CompareTo(FixedString64Bytes other)
		{
			return 0;
		}

		public static bool operator ==(in NativeText a, in FixedString64Bytes b)
		{
			return false;
		}

		public static bool operator !=(in NativeText a, in FixedString64Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString64Bytes other)
		{
			return false;
		}

		public int CompareTo(FixedString128Bytes other)
		{
			return 0;
		}

		public static bool operator ==(in NativeText a, in FixedString128Bytes b)
		{
			return false;
		}

		public static bool operator !=(in NativeText a, in FixedString128Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString128Bytes other)
		{
			return false;
		}

		public int CompareTo(FixedString512Bytes other)
		{
			return 0;
		}

		public static bool operator ==(in NativeText a, in FixedString512Bytes b)
		{
			return false;
		}

		public static bool operator !=(in NativeText a, in FixedString512Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString512Bytes other)
		{
			return false;
		}

		public int CompareTo(FixedString4096Bytes other)
		{
			return 0;
		}

		public static bool operator ==(in NativeText a, in FixedString4096Bytes b)
		{
			return false;
		}

		public static bool operator !=(in NativeText a, in FixedString4096Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString4096Bytes other)
		{
			return false;
		}

		[ExcludeFromBurstCompatTesting("Returns managed string")]
		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		[ExcludeFromBurstCompatTesting("Takes managed object")]
		public override bool Equals(object other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		internal unsafe static void CheckNull(void* dataPtr)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private readonly void CheckRead()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckWrite()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private readonly void CheckWriteAndBumpSecondaryVersion()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckIndexInRange(int index)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void ThrowCopyError(CopyError error, string source)
		{
		}

		public ReadOnly AsReadOnly()
		{
			return default(ReadOnly);
		}
	}
}
