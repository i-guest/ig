using System.Runtime.InteropServices;

namespace Unity.Collections
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[GenerateTestsForBurstCompatibility]
	public struct Unicode
	{
		[GenerateTestsForBurstCompatibility]
		public struct Rune
		{
			public int value;

			public Rune(int codepoint)
			{
				value = 0;
			}

			public static implicit operator Rune(char codepoint)
			{
				return default(Rune);
			}

			public static bool operator ==(Rune lhs, Rune rhs)
			{
				return false;
			}

			[ExcludeFromBurstCompatTesting("Takes managed object")]
			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public static bool operator !=(Rune lhs, Rune rhs)
			{
				return false;
			}

			public static bool IsDigit(Rune r)
			{
				return false;
			}

			internal bool IsAscii()
			{
				return false;
			}

			internal bool IsLatin1()
			{
				return false;
			}

			internal bool IsDigit()
			{
				return false;
			}

			internal bool IsWhiteSpace()
			{
				return false;
			}

			internal Rune ToLowerAscii()
			{
				return default(Rune);
			}

			internal Rune ToUpperAscii()
			{
				return default(Rune);
			}

			public int LengthInUtf8Bytes()
			{
				return 0;
			}
		}

		public const int kMaximumValidCodePoint = 1114111;

		public static Rune ReplacementCharacter => default(Rune);

		public static Rune BadRune => default(Rune);

		public static bool IsValidCodePoint(int codepoint)
		{
			return false;
		}

		public static bool NotTrailer(byte b)
		{
			return false;
		}

		public unsafe static ConversionError Utf8ToUcs(out Rune rune, byte* buffer, ref int index, int capacity)
		{
			rune = default(Rune);
			return default(ConversionError);
		}

		private unsafe static int FindUtf8CharStartInReverse(byte* ptr, ref int index)
		{
			return 0;
		}

		internal unsafe static ConversionError Utf8ToUcsReverse(out Rune rune, byte* buffer, ref int index, int capacity)
		{
			rune = default(Rune);
			return default(ConversionError);
		}

		private static bool IsLeadingSurrogate(char c)
		{
			return false;
		}

		private static bool IsTrailingSurrogate(char c)
		{
			return false;
		}

		public unsafe static ConversionError Utf16ToUcs(out Rune rune, char* buffer, ref int index, int capacity)
		{
			rune = default(Rune);
			return default(ConversionError);
		}

		internal unsafe static ConversionError UcsToUcs(out Rune rune, Rune* buffer, ref int index, int capacity)
		{
			rune = default(Rune);
			return default(ConversionError);
		}

		public unsafe static ConversionError UcsToUtf8(byte* buffer, ref int index, int capacity, Rune rune)
		{
			return default(ConversionError);
		}

		public unsafe static ConversionError UcsToUtf16(char* buffer, ref int index, int capacity, Rune rune)
		{
			return default(ConversionError);
		}

		public unsafe static ConversionError Utf16ToUtf8(char* utf16Buffer, int utf16Length, byte* utf8Buffer, out int utf8Length, int utf8Capacity)
		{
			utf8Length = default(int);
			return default(ConversionError);
		}

		public unsafe static ConversionError Utf8ToUtf8(byte* srcBuffer, int srcLength, byte* destBuffer, out int destLength, int destCapacity)
		{
			destLength = default(int);
			return default(ConversionError);
		}

		public unsafe static ConversionError Utf8ToUtf16(byte* utf8Buffer, int utf8Length, char* utf16Buffer, out int utf16Length, int utf16Capacity)
		{
			utf16Length = default(int);
			return default(ConversionError);
		}

		private unsafe static int CountRunes(byte* utf8Buffer, int utf8Length, int maxRunes = 2147483647)
		{
			return 0;
		}
	}
}
