using System;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.Collections
{
	[MovedFrom(true, "Unity.Networking.Transport", null, null)]
	[GenerateTestsForBurstCompatibility]
	public struct DataStreamReader
	{
		private struct Context
		{
			public int m_ReadByteIndex;

			public int m_BitIndex;

			public ulong m_BitBuffer;

			public int m_FailedReads;
		}

		[NativeDisableUnsafePtrRestriction]
		internal unsafe byte* m_BufferPtr;

		private Context m_Context;

		private int m_Length;

		public static bool IsLittleEndian => false;

		public readonly bool HasFailedReads => false;

		public readonly int Length => 0;

		public readonly bool IsCreated => false;

		public unsafe DataStreamReader(NativeArray<byte> array)
		{
			m_BufferPtr = null;
			m_Context = default(Context);
			m_Length = 0;
		}

		private static void Initialize(out DataStreamReader self, NativeArray<byte> array)
		{
			self = default(DataStreamReader);
		}

		private static short ByteSwap(short val)
		{
			return 0;
		}

		private static int ByteSwap(int val)
		{
			return 0;
		}

		private unsafe void ReadBytesInternal(byte* data, int length)
		{
		}

		public void ReadBytes(NativeArray<byte> array)
		{
		}

		public void ReadBytes(Span<byte> span)
		{
		}

		public int GetBytesRead()
		{
			return 0;
		}

		public int GetBitsRead()
		{
			return 0;
		}

		public void SeekSet(int pos)
		{
		}

		public byte ReadByte()
		{
			return 0;
		}

		public short ReadShort()
		{
			return 0;
		}

		public ushort ReadUShort()
		{
			return 0;
		}

		public int ReadInt()
		{
			return 0;
		}

		public uint ReadUInt()
		{
			return 0u;
		}

		public long ReadLong()
		{
			return 0L;
		}

		public ulong ReadULong()
		{
			return 0uL;
		}

		public void Flush()
		{
		}

		public short ReadShortNetworkByteOrder()
		{
			return 0;
		}

		public ushort ReadUShortNetworkByteOrder()
		{
			return 0;
		}

		public int ReadIntNetworkByteOrder()
		{
			return 0;
		}

		public uint ReadUIntNetworkByteOrder()
		{
			return 0u;
		}

		public float ReadFloat()
		{
			return 0f;
		}

		public double ReadDouble()
		{
			return 0.0;
		}

		public uint ReadPackedUInt(in StreamCompressionModel model)
		{
			return 0u;
		}

		private uint ReadPackedUIntInternal(int maxSymbolLength, in StreamCompressionModel model)
		{
			return 0u;
		}

		private void FillBitBuffer()
		{
		}

		private uint ReadRawBitsInternal(int numbits)
		{
			return 0u;
		}

		public uint ReadRawBits(int numbits)
		{
			return 0u;
		}

		public ulong ReadPackedULong(in StreamCompressionModel model)
		{
			return 0uL;
		}

		public int ReadPackedInt(in StreamCompressionModel model)
		{
			return 0;
		}

		public long ReadPackedLong(in StreamCompressionModel model)
		{
			return 0L;
		}

		public float ReadPackedFloat(in StreamCompressionModel model)
		{
			return 0f;
		}

		public double ReadPackedDouble(in StreamCompressionModel model)
		{
			return 0.0;
		}

		public int ReadPackedIntDelta(int baseline, in StreamCompressionModel model)
		{
			return 0;
		}

		public uint ReadPackedUIntDelta(uint baseline, in StreamCompressionModel model)
		{
			return 0u;
		}

		public long ReadPackedLongDelta(long baseline, in StreamCompressionModel model)
		{
			return 0L;
		}

		public ulong ReadPackedULongDelta(ulong baseline, in StreamCompressionModel model)
		{
			return 0uL;
		}

		public float ReadPackedFloatDelta(float baseline, in StreamCompressionModel model)
		{
			return 0f;
		}

		public double ReadPackedDoubleDelta(double baseline, in StreamCompressionModel model)
		{
			return 0.0;
		}

		public FixedString32Bytes ReadFixedString32()
		{
			return default(FixedString32Bytes);
		}

		public FixedString64Bytes ReadFixedString64()
		{
			return default(FixedString64Bytes);
		}

		public FixedString128Bytes ReadFixedString128()
		{
			return default(FixedString128Bytes);
		}

		public FixedString512Bytes ReadFixedString512()
		{
			return default(FixedString512Bytes);
		}

		public FixedString4096Bytes ReadFixedString4096()
		{
			return default(FixedString4096Bytes);
		}

		public ushort ReadFixedString(NativeArray<byte> array)
		{
			return 0;
		}

		private unsafe ushort ReadFixedStringInternal(byte* data, int maxLength)
		{
			return 0;
		}

		public FixedString32Bytes ReadPackedFixedString32Delta(FixedString32Bytes baseline, in StreamCompressionModel model)
		{
			return default(FixedString32Bytes);
		}

		public FixedString64Bytes ReadPackedFixedString64Delta(FixedString64Bytes baseline, in StreamCompressionModel model)
		{
			return default(FixedString64Bytes);
		}

		public FixedString128Bytes ReadPackedFixedString128Delta(FixedString128Bytes baseline, in StreamCompressionModel model)
		{
			return default(FixedString128Bytes);
		}

		public FixedString512Bytes ReadPackedFixedString512Delta(FixedString512Bytes baseline, in StreamCompressionModel model)
		{
			return default(FixedString512Bytes);
		}

		public FixedString4096Bytes ReadPackedFixedString4096Delta(FixedString4096Bytes baseline, in StreamCompressionModel model)
		{
			return default(FixedString4096Bytes);
		}

		public ushort ReadPackedFixedStringDelta(NativeArray<byte> data, NativeArray<byte> baseData, in StreamCompressionModel model)
		{
			return 0;
		}

		private unsafe ushort ReadPackedFixedStringDeltaInternal(byte* data, int maxLength, byte* baseData, ushort baseLength, in StreamCompressionModel model)
		{
			return 0;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		internal readonly void CheckRead()
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckBits(int numBits)
		{
		}
	}
}
