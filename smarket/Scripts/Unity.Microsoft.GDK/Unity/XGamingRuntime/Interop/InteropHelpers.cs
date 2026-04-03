using System;

namespace Unity.XGamingRuntime.Interop
{
	public static class InteropHelpers
	{
		public static IntPtr MarshalStringUtf8(string str)
		{
			return (IntPtr)0;
		}

		public static U[] MarshalArray<T, U>(IntPtr ptr, uint count, Func<T, U> converter) where T : struct
		{
			return null;
		}

		public static T[] MarshalArray<T>(IntPtr ptr, uint count) where T : struct
		{
			return null;
		}

		public static string[] MarshalStringArrayAnsi(IntPtr ptr, uint count)
		{
			return null;
		}
	}
}
