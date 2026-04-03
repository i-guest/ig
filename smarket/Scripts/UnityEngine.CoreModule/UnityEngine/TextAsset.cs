using System;
using System.Collections.Generic;
using System.Text;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Scripting/TextAsset.h")]
	public class TextAsset : Object
	{
		internal enum CreateOptions
		{
			None = 0,
			CreateNativeObject = 1
		}

		private static class EncodingUtility
		{
			internal static readonly KeyValuePair<byte[], Encoding>[] encodingLookup;

			internal static readonly Encoding targetEncoding;

			static EncodingUtility()
			{
			}
		}

		public byte[] bytes => null;

		public string text => null;

		private static void Internal_CreateInstance([Writable] TextAsset self, string text)
		{
		}

		private IntPtr GetDataPtr()
		{
			return (IntPtr)0;
		}

		private long GetDataSize()
		{
			return 0L;
		}

		public override string ToString()
		{
			return null;
		}

		public TextAsset()
		{
		}

		internal TextAsset(CreateOptions options, string text)
		{
		}

		public NativeArray<T> GetData<T>() where T : struct
		{
			return default(NativeArray<T>);
		}

		internal static string DecodeString(byte[] bytes)
		{
			return null;
		}

		private static byte[] get_bytes_Injected(IntPtr _unity_self)
		{
			return null;
		}

		private static void Internal_CreateInstance_Injected([Writable] TextAsset self, ref ManagedSpanWrapper text)
		{
		}

		private static IntPtr GetDataPtr_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static long GetDataSize_Injected(IntPtr _unity_self)
		{
			return 0L;
		}
	}
}
