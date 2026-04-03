using System.Collections.Generic;

namespace UnityEngine.AddressableAssets.Utility
{
	internal static class SerializationUtilities
	{
		internal enum ObjectType
		{
			AsciiString = 0,
			UnicodeString = 1,
			UInt16 = 2,
			UInt32 = 3,
			Int32 = 4,
			Hash128 = 5,
			Type = 6,
			JsonObject = 7
		}

		internal static int ReadInt32FromByteArray(byte[] data, int offset)
		{
			return 0;
		}

		internal static int WriteInt32ToByteArray(byte[] data, int val, int offset)
		{
			return 0;
		}

		internal static object ReadObjectFromByteArray(byte[] keyData, int dataIndex)
		{
			return null;
		}

		internal static int WriteObjectToByteList(object obj, List<byte> buffer)
		{
			return 0;
		}
	}
}
