using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.Collections
{
	[MovedFrom(true, "Unity.Networking.Transport", "Unity.Networking.Transport", null)]
	[GenerateTestsForBurstCompatibility]
	public struct DataStreamWriter
	{
		private struct StreamData
		{
			public unsafe byte* buffer;

			public int length;

			public int capacity;

			public ulong bitBuffer;

			public int bitIndex;

			public int failedWrites;
		}

		[NativeDisableUnsafePtrRestriction]
		private StreamData m_Data;

		public IntPtr m_SendHandleData;

		public static bool IsLittleEndian => false;

		public readonly bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public readonly bool HasFailedWrites
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
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

		public int Length => 0;

		public int LengthInBits => 0;

		public DataStreamWriter(int length, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = default(StreamData);
			m_SendHandleData = (IntPtr)0;
		}

		public DataStreamWriter(NativeArray<byte> data)
		{
			m_Data = default(StreamData);
			m_SendHandleData = (IntPtr)0;
		}

		public unsafe DataStreamWriter(byte* data, int length)
		{
			m_Data = default(StreamData);
			m_SendHandleData = (IntPtr)0;
		}

		public NativeArray<byte> AsNativeArray()
		{
			return default(NativeArray<byte>);
		}

		private static void Initialize(out DataStreamWriter self, NativeArray<byte> data)
		{
			self = default(DataStreamWriter);
		}

		private static short ByteSwap(short val)
		{
			return 0;
		}

		private static int ByteSwap(int val)
		{
			return 0;
		}

		private void SyncBitData()
		{
		}

		public void Flush()
		{
		}

		private unsafe bool WriteBytesInternal(byte* data, int bytes)
		{
			return false;
		}

		public bool WriteByte(byte value)
		{
			return false;
		}

		public bool WriteBytes(NativeArray<byte> value)
		{
			return false;
		}

		public bool WriteBytes(Span<byte> value)
		{
			return false;
		}

		public bool WriteShort(short value)
		{
			return false;
		}

		public bool WriteUShort(ushort value)
		{
			return false;
		}

		public bool WriteInt(int value)
		{
			return false;
		}

		public bool WriteUInt(uint value)
		{
			return false;
		}

		public bool WriteLong(long value)
		{
			return false;
		}

		public bool WriteULong(ulong value)
		{
			return false;
		}

		public bool WriteShortNetworkByteOrder(short value)
		{
			return false;
		}

		public bool WriteUShortNetworkByteOrder(ushort value)
		{
			return false;
		}

		public bool WriteIntNetworkByteOrder(int value)
		{
			return false;
		}

		public bool WriteUIntNetworkByteOrder(uint value)
		{
			return false;
		}

		public bool WriteFloat(float value)
		{
			return false;
		}

		public bool WriteDouble(double value)
		{
			return false;
		}

		private void FlushBits()
		{
		}

		private void WriteRawBitsInternal(uint value, int numbits)
		{
		}

		public bool WriteRawBits(uint value, int numbits)
		{
			return false;
		}

		public bool WritePackedUInt(uint value, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedULong(ulong value, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedInt(int value, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedLong(long value, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedFloat(float value, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedDouble(double value, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedUIntDelta(uint value, uint baseline, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedIntDelta(int value, int baseline, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedLongDelta(long value, long baseline, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedULongDelta(ulong value, ulong baseline, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedFloatDelta(float value, float baseline, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedDoubleDelta(double value, double baseline, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WriteFixedString32(FixedString32Bytes str)
		{
			return false;
		}

		public bool WriteFixedString64(FixedString64Bytes str)
		{
			return false;
		}

		public bool WriteFixedString128(FixedString128Bytes str)
		{
			return false;
		}

		public bool WriteFixedString512(FixedString512Bytes str)
		{
			return false;
		}

		public bool WriteFixedString4096(FixedString4096Bytes str)
		{
			return false;
		}

		public bool WritePackedFixedString32Delta(FixedString32Bytes str, FixedString32Bytes baseline, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedFixedString64Delta(FixedString64Bytes str, FixedString64Bytes baseline, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedFixedString128Delta(FixedString128Bytes str, FixedString128Bytes baseline, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedFixedString512Delta(FixedString512Bytes str, FixedString512Bytes baseline, in StreamCompressionModel model)
		{
			return false;
		}

		public bool WritePackedFixedString4096Delta(FixedString4096Bytes str, FixedString4096Bytes baseline, in StreamCompressionModel model)
		{
			return false;
		}

		private unsafe bool WritePackedFixedStringDelta(byte* data, uint length, byte* baseData, uint baseLength, in StreamCompressionModel model)
		{
			return false;
		}

		public void Clear()
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

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckAllocator(AllocatorManager.AllocatorHandle allocator)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckBits(uint value, int numBits)
		{
		}
	}
}
