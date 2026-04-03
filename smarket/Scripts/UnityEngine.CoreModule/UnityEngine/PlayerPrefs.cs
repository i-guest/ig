using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
	public class PlayerPrefs
	{
		[NativeMethod("SetInt")]
		private static bool TrySetInt(string key, int value)
		{
			return false;
		}

		[NativeMethod("SetFloat")]
		private static bool TrySetFloat(string key, float value)
		{
			return false;
		}

		[NativeMethod("SetString")]
		private static bool TrySetSetString(string key, string value)
		{
			return false;
		}

		public static void SetInt(string key, int value)
		{
		}

		public static int GetInt(string key, int defaultValue)
		{
			return 0;
		}

		public static int GetInt(string key)
		{
			return 0;
		}

		public static void SetFloat(string key, float value)
		{
		}

		public static float GetFloat(string key, float defaultValue)
		{
			return 0f;
		}

		public static void SetString(string key, string value)
		{
		}

		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		public static string GetString(string key)
		{
			return null;
		}

		public static bool HasKey(string key)
		{
			return false;
		}

		public static void DeleteKey(string key)
		{
		}

		[NativeMethod("Sync")]
		public static void Save()
		{
		}

		private static bool TrySetInt_Injected(ref ManagedSpanWrapper key, int value)
		{
			return false;
		}

		private static bool TrySetFloat_Injected(ref ManagedSpanWrapper key, float value)
		{
			return false;
		}

		private static bool TrySetSetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper value)
		{
			return false;
		}

		private static int GetInt_Injected(ref ManagedSpanWrapper key, int defaultValue)
		{
			return 0;
		}

		private static float GetFloat_Injected(ref ManagedSpanWrapper key, float defaultValue)
		{
			return 0f;
		}

		private static void GetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static bool HasKey_Injected(ref ManagedSpanWrapper key)
		{
			return false;
		}

		private static void DeleteKey_Injected(ref ManagedSpanWrapper key)
		{
		}
	}
}
