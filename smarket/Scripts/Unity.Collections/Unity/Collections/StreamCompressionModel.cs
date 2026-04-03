using System.Diagnostics;
using Unity.Burst;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility]
	public struct StreamCompressionModel
	{
		private static class SharedStaticCompressionModel
		{
			internal static readonly SharedStatic<StreamCompressionModel> Default;
		}

		internal static readonly byte[] k_BucketSizes;

		internal static readonly uint[] k_BucketOffsets;

		internal static readonly int[] k_FirstBucketCandidate;

		internal static readonly byte[] k_DefaultModelData;

		internal const int k_AlphabetSize = 16;

		internal const int k_MaxHuffmanSymbolLength = 6;

		internal const int k_MaxContexts = 1;

		private byte m_Initialized;

		internal unsafe fixed ushort encodeTable[16];

		internal unsafe fixed ushort decodeTable[64];

		internal unsafe fixed byte bucketSizes[16];

		internal unsafe fixed uint bucketOffsets[16];

		public static StreamCompressionModel Default => default(StreamCompressionModel);

		private static void Initialize()
		{
		}

		private static void GenerateHuffmanCodes(NativeArray<byte> symbolCodes, int symbolCodesOffset, NativeArray<byte> symbolLengths, int symbolLengthsOffset, int alphabetSize, int maxCodeLength)
		{
		}

		private static uint ReverseBits(uint value, int num_bits)
		{
			return 0u;
		}

		private static void GenerateHuffmanDecodeTable(NativeArray<ushort> decodeTable, int decodeTableOffset, NativeArray<byte> symbolLengths, NativeArray<byte> symbolCodes, int alphabetSize, int maxCodeLength)
		{
		}

		public readonly int CalculateBucket(uint value)
		{
			return 0;
		}

		public readonly int GetCompressedSizeInBits(uint value)
		{
			return 0;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckAlphabetSize(int alphabetSize)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckSymbolLength(NativeArray<byte> symbolLengths, int symbolLengthsOffset, int symbol, int length)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckAlphabetAndMaxCodeLength(int alphabetSize, int maxCodeLength)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckExceedMaxCodeLength(int length, int maxCodeLength)
		{
		}
	}
}
