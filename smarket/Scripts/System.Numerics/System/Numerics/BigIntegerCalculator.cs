namespace System.Numerics
{
	internal static class BigIntegerCalculator
	{
		internal struct BitsBuffer
		{
			private uint[] _bits;

			private int _length;

			public BitsBuffer(int size, uint value)
			{
				_bits = null;
				_length = 0;
			}

			public BitsBuffer(int size, uint[] value)
			{
				_bits = null;
				_length = 0;
			}

			public void MultiplySelf(ref BitsBuffer value, ref BitsBuffer temp)
			{
			}

			public void SquareSelf(ref BitsBuffer temp)
			{
			}

			public void Reduce(ref FastReducer reducer)
			{
			}

			public void Reduce(uint[] modulus)
			{
			}

			public uint[] GetBits()
			{
				return null;
			}

			public int GetSize()
			{
				return 0;
			}

			private void Apply(ref BitsBuffer temp, int maxLength)
			{
			}
		}

		internal readonly struct FastReducer
		{
			private readonly uint[] _modulus;

			private readonly uint[] _mu;

			private readonly uint[] _q1;

			private readonly uint[] _q2;

			private readonly int _muLength;

			public FastReducer(uint[] modulus)
			{
				_modulus = null;
				_mu = null;
				_q1 = null;
				_q2 = null;
				_muLength = 0;
			}

			public int Reduce(uint[] value, int length)
			{
				return 0;
			}

			private static int DivMul(uint[] left, int leftLength, uint[] right, int rightLength, uint[] bits, int k)
			{
				return 0;
			}

			private static int SubMod(uint[] left, int leftLength, uint[] right, int rightLength, uint[] modulus, int k)
			{
				return 0;
			}
		}

		private static int ReducerThreshold;

		private static int SquareThreshold;

		private static int AllocationThreshold;

		private static int MultiplyThreshold;

		public static uint[] Add(uint[] left, uint right)
		{
			return null;
		}

		public static uint[] Add(uint[] left, uint[] right)
		{
			return null;
		}

		private unsafe static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
		}

		private unsafe static void AddSelf(uint* left, int leftLength, uint* right, int rightLength)
		{
		}

		public static uint[] Subtract(uint[] left, uint right)
		{
			return null;
		}

		public static uint[] Subtract(uint[] left, uint[] right)
		{
			return null;
		}

		private unsafe static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
		}

		private unsafe static void SubtractSelf(uint* left, int leftLength, uint* right, int rightLength)
		{
		}

		public static int Compare(uint[] left, uint[] right)
		{
			return 0;
		}

		private unsafe static int Compare(uint* left, int leftLength, uint* right, int rightLength)
		{
			return 0;
		}

		public static uint[] Divide(uint[] left, uint right)
		{
			return null;
		}

		public static uint Remainder(uint[] left, uint right)
		{
			return 0u;
		}

		public static uint[] Divide(uint[] left, uint[] right)
		{
			return null;
		}

		public static uint[] Remainder(uint[] left, uint[] right)
		{
			return null;
		}

		private unsafe static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
		}

		private unsafe static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength)
		{
			return 0u;
		}

		private unsafe static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q)
		{
			return 0u;
		}

		private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo)
		{
			return false;
		}

		private static uint[] CreateCopy(uint[] value)
		{
			return null;
		}

		private static int LeadingZeros(uint value)
		{
			return 0;
		}

		public static uint Pow(uint value, uint power, uint modulus)
		{
			return 0u;
		}

		public static uint Pow(uint[] value, uint power, uint modulus)
		{
			return 0u;
		}

		public static uint Pow(uint value, uint[] power, uint modulus)
		{
			return 0u;
		}

		public static uint Pow(uint[] value, uint[] power, uint modulus)
		{
			return 0u;
		}

		private static uint PowCore(uint[] power, uint modulus, ulong value, ulong result)
		{
			return 0u;
		}

		private static uint PowCore(uint power, uint modulus, ulong value, ulong result)
		{
			return 0u;
		}

		public static uint[] Pow(uint value, uint power, uint[] modulus)
		{
			return null;
		}

		public static uint[] Pow(uint[] value, uint power, uint[] modulus)
		{
			return null;
		}

		public static uint[] Pow(uint value, uint[] power, uint[] modulus)
		{
			return null;
		}

		public static uint[] Pow(uint[] value, uint[] power, uint[] modulus)
		{
			return null;
		}

		private static uint[] PowCore(uint[] power, uint[] modulus, ref BitsBuffer value)
		{
			return null;
		}

		private static uint[] PowCore(uint power, uint[] modulus, ref BitsBuffer value)
		{
			return null;
		}

		private static void PowCore(uint[] power, uint[] modulus, ref BitsBuffer value, ref BitsBuffer result, ref BitsBuffer temp)
		{
		}

		private static void PowCore(uint power, uint[] modulus, ref BitsBuffer value, ref BitsBuffer result, ref BitsBuffer temp)
		{
		}

		private static void PowCore(uint[] power, ref FastReducer reducer, ref BitsBuffer value, ref BitsBuffer result, ref BitsBuffer temp)
		{
		}

		private static void PowCore(uint power, ref FastReducer reducer, ref BitsBuffer value, ref BitsBuffer result, ref BitsBuffer temp)
		{
		}

		private static int ActualLength(uint[] value)
		{
			return 0;
		}

		private static int ActualLength(uint[] value, int length)
		{
			return 0;
		}

		public static uint[] Square(uint[] value)
		{
			return null;
		}

		private unsafe static void Square(uint* value, int valueLength, uint* bits, int bitsLength)
		{
		}

		public static uint[] Multiply(uint[] left, uint right)
		{
			return null;
		}

		public static uint[] Multiply(uint[] left, uint[] right)
		{
			return null;
		}

		private unsafe static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
		}

		private unsafe static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength)
		{
		}
	}
}
