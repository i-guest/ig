using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnityEngine.ResourceManagement.Util
{
	internal class BinaryStorageBuffer
	{
		private class BuiltinTypesSerializer : ISerializationAdapter<int>, ISerializationAdapter, ISerializationAdapter<bool>, ISerializationAdapter<long>, ISerializationAdapter<string>, ISerializationAdapter<Hash128>
		{
			private struct ObjectToStringRemap
			{
				public uint stringId;

				public char separator;
			}

			public IEnumerable<ISerializationAdapter> Dependencies => null;

			public object Deserialize(Reader reader, Type t, uint offset, out uint size)
			{
				size = default(uint);
				return null;
			}

			private char FindBestSeparator(string str, params char[] seps)
			{
				return '\0';
			}

			public uint Serialize(Writer writer, object val)
			{
				return 0u;
			}
		}

		private class TypeSerializer : ISerializationAdapter<Type>, ISerializationAdapter
		{
			private struct Data
			{
				public uint assemblyId;

				public uint classId;
			}

			public IEnumerable<ISerializationAdapter> Dependencies => null;

			public object Deserialize(Reader reader, Type type, uint offset, out uint size)
			{
				size = default(uint);
				return null;
			}

			public uint Serialize(Writer writer, object val)
			{
				return 0u;
			}
		}

		private struct DynamicString
		{
			public uint stringId;

			public uint nextId;
		}

		private struct ObjectTypeData
		{
			public uint typeId;

			public uint objectId;
		}

		public interface ISerializationAdapter
		{
			IEnumerable<ISerializationAdapter> Dependencies { get; }

			uint Serialize(Writer writer, object val);

			object Deserialize(Reader reader, Type t, uint offset, out uint size);
		}

		public interface ISerializationAdapter<T> : ISerializationAdapter
		{
		}

		public class Reader
		{
			private class StringCreationState
			{
				public uint id;

				public char sep;

				public int length;

				public uint size;
			}

			private byte[] m_Buffer;

			private Dictionary<Type, ISerializationAdapter> m_Adapters;

			private LRUCache<uint, object> m_Cache;

			private uint m_MinCachedObjectSize;

			private StringBuilder stringBuilder;

			private static StringCreationState stringCreationState;

			public void GetCacheStats(out int reqCount, out int reqHits)
			{
				reqCount = default(int);
				reqHits = default(int);
			}

			public void ResetCache(int maxCachedObjects, uint minCachedObjSize)
			{
			}

			private void Init(byte[] data, int maxCachedObjects, uint minCachedObjSize, params ISerializationAdapter[] adapters)
			{
			}

			public void AddSerializationAdapter(ISerializationAdapter a)
			{
			}

			public Reader(byte[] data, int maxCachedObjects = 1024, uint minCachedObjSize = 64u, params ISerializationAdapter[] adapters)
			{
			}

			internal byte[] GetBuffer()
			{
				return null;
			}

			public Reader(Stream inputStream, uint bufferSize, int maxCachedObjects, uint minCachedObjSize, params ISerializationAdapter[] adapters)
			{
			}

			private bool TryGetCachedValue(Type t, uint offset, out object val)
			{
				val = null;
				return false;
			}

			private bool TryGetCachedValue<T>(uint offset, out T val)
			{
				val = default(T);
				return false;
			}

			public T[] ReadValueArray<T>(uint id, out uint readSize, bool cacheValue = true) where T : struct
			{
				readSize = default(uint);
				return null;
			}

			public uint ProcessObjectArray<T, C>(uint id, out uint size, C context, Action<T, C, int, int> procFunc, bool cacheValues = true)
			{
				size = default(uint);
				return 0u;
			}

			public uint ReadObjectArray<T>(ref List<T> results, uint id, out uint size, bool cacheValues = true)
			{
				size = default(uint);
				return 0u;
			}

			public object[] ReadObjectArray(uint id, out uint size, bool cacheValues = true, bool cacheFullArray = false)
			{
				size = default(uint);
				return null;
			}

			public object[] ReadObjectArray(Type t, uint id, out uint size, bool cacheValues = true, bool cacheFullArray = false)
			{
				size = default(uint);
				return null;
			}

			public T[] ReadObjectArray<T>(uint id, out uint size, bool cacheValues = true, bool cacheFullArray = false)
			{
				size = default(uint);
				return null;
			}

			public object ReadObject(uint id, out uint size, bool cacheValue = true)
			{
				size = default(uint);
				return null;
			}

			public T ReadObject<T>(uint id, out uint size, bool cacheValue = true)
			{
				size = default(uint);
				return default(T);
			}

			public object ReadObject(Type t, uint id, out uint size, bool cacheValue = true)
			{
				size = default(uint);
				return null;
			}

			public T ReadValue<T>(uint id, out uint size) where T : struct
			{
				size = default(uint);
				return default(T);
			}

			public string ReadString(uint id, out uint size, char sep = '\0', bool cacheValue = true)
			{
				size = default(uint);
				return null;
			}

			private string ReadStringInternal(uint offset, out uint size, Encoding enc, bool cacheValue = true)
			{
				size = default(uint);
				return null;
			}

			private string ReadAutoEncodedString(uint id, out uint size, bool cacheValue)
			{
				size = default(uint);
				return null;
			}

			public int ComputeStringLength(uint id, char sep = '\0')
			{
				return 0;
			}

			private int GetDynamicStringLength(uint id, char sep)
			{
				return 0;
			}

			private int GetAutoEncodedStringLength(uint id)
			{
				return 0;
			}

			private int GetStringLengthInternal(uint offset, Encoding enc)
			{
				return 0;
			}

			private string ReadDynamicString(uint id, out uint size, char sep, bool cacheValue)
			{
				size = default(uint);
				return null;
			}
		}

		public class Writer
		{
			private class Chunk
			{
				public uint position;

				public byte[] data;
			}

			private struct StringParts
			{
				public string str;

				public uint dataSize;

				public bool isUnicode;
			}

			private uint totalBytes;

			private uint defaulChunkSize;

			private List<Chunk> chunks;

			private Dictionary<Hash128, uint> existingValues;

			private Dictionary<Type, ISerializationAdapter> serializationAdapters;

			public uint Length => 0u;

			public Writer(int chunkSize = 1048576, params ISerializationAdapter[] adapters)
			{
			}

			private Chunk FindChunkWithSpace(uint length)
			{
				return null;
			}

			private unsafe uint WriteInternal(void* pData, uint dataSize, bool prefixSize)
			{
				return 0u;
			}

			private uint ReserveInternal(uint dataSize, bool prefixSize)
			{
				return 0u;
			}

			private unsafe void WriteInternal(uint id, void* pData, uint dataSize, bool prefixSize)
			{
			}

			public uint Reserve<T>() where T : struct
			{
				return 0u;
			}

			public uint Write<T>(in T val) where T : struct
			{
				return 0u;
			}

			public uint Write<T>(T val) where T : struct
			{
				return 0u;
			}

			public uint Write<T>(uint offset, in T val) where T : struct
			{
				return 0u;
			}

			public uint Write<T>(uint offset, T val) where T : struct
			{
				return 0u;
			}

			public uint Reserve<T>(uint count) where T : struct
			{
				return 0u;
			}

			public uint Write<T>(T[] values, bool hashElements = true) where T : struct
			{
				return 0u;
			}

			public uint Write<T>(uint offset, T[] values, bool hashElements = true) where T : struct
			{
				return 0u;
			}

			public uint WriteObjects<T>(IEnumerable<T> objs, bool serizalizeTypeData)
			{
				return 0u;
			}

			public uint WriteObject(object obj, bool serializeTypeData)
			{
				return 0u;
			}

			public uint WriteString(string str, char sep = '\0')
			{
				return 0u;
			}

			private uint WriteStringInternal(string val, Encoding enc)
			{
				return 0u;
			}

			public byte[] SerializeToByteArray()
			{
				return null;
			}

			public uint SerializeToStream(Stream str)
			{
				return 0u;
			}

			private static bool IsUnicode(string str)
			{
				return false;
			}

			private uint WriteAutoEncodedString(string str)
			{
				return 0u;
			}

			private uint WriteUnicodeString(string str)
			{
				return 0u;
			}

			private static uint ComputeStringSize(string str, out bool isUnicode)
			{
				isUnicode = default(bool);
				return 0u;
			}

			private uint WriteDynamicString(string str, char sep)
			{
				return 0u;
			}

			private uint RecurseDynamicStringParts(StringParts[] parts, int index, char sep, uint minSize)
			{
				return 0u;
			}
		}

		private const uint kUnicodeStringFlag = 2147483648u;

		private const uint kDynamicStringFlag = 1073741824u;

		private const uint kClearFlagsMask = 1073741823u;

		private unsafe static void ComputeHash(void* pData, ulong size, Hash128* hash)
		{
		}

		private static void AddSerializationAdapter(Dictionary<Type, ISerializationAdapter> serializationAdapters, ISerializationAdapter adapter, bool forceOverride = false)
		{
		}

		private static bool GetSerializationAdapter(Dictionary<Type, ISerializationAdapter> serializationAdapters, Type t, out ISerializationAdapter adapter)
		{
			adapter = null;
			return false;
		}
	}
}
