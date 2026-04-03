using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
	public static class JsonUtility
	{
		[FreeFunction("ToJsonInternal", true)]
		[ThreadSafe]
		private static string ToJsonInternal([NotNull] object obj, bool prettyPrint)
		{
			return null;
		}

		[FreeFunction("FromJsonInternal", true, ThrowsException = true)]
		[ThreadSafe]
		private static object FromJsonInternal(string json, object objectToOverwrite, Type type)
		{
			return null;
		}

		public static string ToJson(object obj)
		{
			return null;
		}

		public static string ToJson(object obj, bool prettyPrint)
		{
			return null;
		}

		public static T FromJson<T>(string json)
		{
			return default(T);
		}

		public static object FromJson(string json, Type type)
		{
			return null;
		}

		public static void FromJsonOverwrite(string json, object objectToOverwrite)
		{
		}

		private static void ToJsonInternal_Injected(object obj, bool prettyPrint, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static object FromJsonInternal_Injected(ref ManagedSpanWrapper json, object objectToOverwrite, Type type)
		{
			return null;
		}
	}
}
