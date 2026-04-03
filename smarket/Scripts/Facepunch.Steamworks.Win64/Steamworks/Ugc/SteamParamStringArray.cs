using System;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	internal struct SteamParamStringArray : IDisposable
	{
		public SteamParamStringArray_t Value;

		private IntPtr[] NativeStrings;

		private IntPtr NativeArray;

		public static SteamParamStringArray From(string[] array)
		{
			return default(SteamParamStringArray);
		}

		public void Dispose()
		{
		}
	}
}
