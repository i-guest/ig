namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	public static class DataStreamExtensions
	{
		public unsafe static DataStreamWriter Create(byte* data, int length)
		{
			return default(DataStreamWriter);
		}

		public unsafe static bool WriteBytesUnsafe(this ref DataStreamWriter writer, byte* data, int bytes)
		{
			return false;
		}

		public unsafe static void ReadBytesUnsafe(this ref DataStreamReader reader, byte* data, int length)
		{
		}

		public unsafe static ushort ReadFixedStringUnsafe(this ref DataStreamReader reader, byte* data, int maxLength)
		{
			return 0;
		}

		public unsafe static ushort ReadPackedFixedStringDeltaUnsafe(this ref DataStreamReader reader, byte* data, int maxLength, byte* baseData, ushort baseLength, StreamCompressionModel model)
		{
			return 0;
		}

		public unsafe static void* GetUnsafeReadOnlyPtr(this ref DataStreamReader reader)
		{
			return null;
		}
	}
}
