using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Properties;
using UnityEngine;

namespace Unity.Collections
{
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 128)]
	[GenerateTestsForBurstCompatibility]
	public struct FixedString128Bytes : INativeList<byte>, IIndexable<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
	{
		public struct Enumerator : IEnumerator
		{
			private FixedString128Bytes target;

			private int offset;

			private Unicode.Rune current;

			public Unicode.Rune Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return default(Unicode.Rune);
				}
			}

			object IEnumerator.Current => null;

			public Enumerator(FixedString128Bytes other)
			{
				target = default(FixedString128Bytes);
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

		internal const ushort utf8MaxLengthInBytes = 125;

		[SerializeField]
		internal ushort utf8LengthInBytes;

		[SerializeField]
		internal FixedBytes126 bytes;

		public static int UTF8MaxLengthInBytes => 0;

		[CreateProperty]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ExcludeFromBurstCompatTesting("Returns managed string")]
		public string Value => null;

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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe readonly byte* GetUnsafePtr()
		{
			return null;
		}

		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref byte ElementAt(int index)
		{
			throw null;
		}

		public void Clear()
		{
		}

		public void Add(in byte value)
		{
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

		public ref FixedList128Bytes<byte> AsFixedList()
		{
			throw null;
		}

		[ExcludeFromBurstCompatTesting("Takes managed string")]
		public FixedString128Bytes(string source)
		{
			utf8LengthInBytes = 0;
			bytes = default(FixedBytes126);
		}

		[ExcludeFromBurstCompatTesting("Takes managed string")]
		internal CopyError Initialize(string source)
		{
			return default(CopyError);
		}

		public FixedString128Bytes(Unicode.Rune rune, int count = 1)
		{
			utf8LengthInBytes = 0;
			bytes = default(FixedBytes126);
		}

		internal FormatError Initialize(Unicode.Rune rune, int count = 1)
		{
			return default(FormatError);
		}

		internal unsafe FormatError Initialize(byte* srcBytes, int srcLength)
		{
			return default(FormatError);
		}

		public FixedString128Bytes(NativeText.ReadOnly other)
		{
			utf8LengthInBytes = 0;
			bytes = default(FixedBytes126);
		}

		public FixedString128Bytes(in UnsafeText other)
		{
			utf8LengthInBytes = 0;
			bytes = default(FixedBytes126);
		}

		public int CompareTo(FixedString32Bytes other)
		{
			return 0;
		}

		public FixedString128Bytes(in FixedString32Bytes other)
		{
			utf8LengthInBytes = 0;
			bytes = default(FixedBytes126);
		}

		internal FormatError Initialize(in FixedString32Bytes other)
		{
			return default(FormatError);
		}

		public static bool operator ==(in FixedString128Bytes a, in FixedString32Bytes b)
		{
			return false;
		}

		public static bool operator !=(in FixedString128Bytes a, in FixedString32Bytes b)
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

		public FixedString128Bytes(in FixedString64Bytes other)
		{
			utf8LengthInBytes = 0;
			bytes = default(FixedBytes126);
		}

		internal FormatError Initialize(in FixedString64Bytes other)
		{
			return default(FormatError);
		}

		public static bool operator ==(in FixedString128Bytes a, in FixedString64Bytes b)
		{
			return false;
		}

		public static bool operator !=(in FixedString128Bytes a, in FixedString64Bytes b)
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

		public FixedString128Bytes(in FixedString128Bytes other)
		{
			utf8LengthInBytes = 0;
			bytes = default(FixedBytes126);
		}

		internal FormatError Initialize(in FixedString128Bytes other)
		{
			return default(FormatError);
		}

		public static bool operator ==(in FixedString128Bytes a, in FixedString128Bytes b)
		{
			return false;
		}

		public static bool operator !=(in FixedString128Bytes a, in FixedString128Bytes b)
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

		public FixedString128Bytes(in FixedString512Bytes other)
		{
			utf8LengthInBytes = 0;
			bytes = default(FixedBytes126);
		}

		internal FormatError Initialize(in FixedString512Bytes other)
		{
			return default(FormatError);
		}

		public static bool operator ==(in FixedString128Bytes a, in FixedString512Bytes b)
		{
			return false;
		}

		public static bool operator !=(in FixedString128Bytes a, in FixedString512Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString512Bytes other)
		{
			return false;
		}

		public static implicit operator FixedString512Bytes(in FixedString128Bytes fs)
		{
			return default(FixedString512Bytes);
		}

		public int CompareTo(FixedString4096Bytes other)
		{
			return 0;
		}

		public FixedString128Bytes(in FixedString4096Bytes other)
		{
			utf8LengthInBytes = 0;
			bytes = default(FixedBytes126);
		}

		internal FormatError Initialize(in FixedString4096Bytes other)
		{
			return default(FormatError);
		}

		public static bool operator ==(in FixedString128Bytes a, in FixedString4096Bytes b)
		{
			return false;
		}

		public static bool operator !=(in FixedString128Bytes a, in FixedString4096Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString4096Bytes other)
		{
			return false;
		}

		public static implicit operator FixedString4096Bytes(in FixedString128Bytes fs)
		{
			return default(FixedString4096Bytes);
		}

		[ExcludeFromBurstCompatTesting("Takes managed string")]
		public static implicit operator FixedString128Bytes(string b)
		{
			return default(FixedString128Bytes);
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
		public override bool Equals(object obj)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private readonly void CheckIndexInRange(int index)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckLengthInRange(int length)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckCapacityInRange(int capacity)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckCopyError(CopyError error, string source)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckFormatError(FormatError error)
		{
		}
	}
}
