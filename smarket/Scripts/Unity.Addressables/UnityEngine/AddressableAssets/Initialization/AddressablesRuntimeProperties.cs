using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.AddressableAssets.Initialization
{
	public static class AddressablesRuntimeProperties
	{
		private static Stack<string> s_TokenStack;

		private static Stack<int> s_TokenStartStack;

		private static bool s_StaticStacksAreInUse;

		private static Dictionary<string, string> s_CachedValues;

		private static Assembly[] GetAssemblies()
		{
			return null;
		}

		internal static int GetCachedValueCount()
		{
			return 0;
		}

		public static void SetPropertyValue(string name, string val)
		{
		}

		public static void ClearCachedPropertyValues()
		{
		}

		public static string EvaluateProperty(string name)
		{
			return null;
		}

		public static string EvaluateString(string inputString)
		{
			return null;
		}

		public static string EvaluateString(string inputString, char startDelimiter, char endDelimiter, Func<string, string> varFunc)
		{
			return null;
		}

		private static string EvaluateStringInternal(string inputString, char startDelimiter, char endDelimiter, Func<string, string> varFunc)
		{
			return null;
		}
	}
}
