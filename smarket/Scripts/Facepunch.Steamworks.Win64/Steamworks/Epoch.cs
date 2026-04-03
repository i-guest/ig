using System;

namespace Steamworks
{
	internal static class Epoch
	{
		private static readonly DateTime epoch;

		public static int Current => 0;

		public static DateTime ToDateTime(decimal unixTime)
		{
			return default(DateTime);
		}

		public static uint FromDateTime(DateTime dt)
		{
			return 0u;
		}
	}
}
