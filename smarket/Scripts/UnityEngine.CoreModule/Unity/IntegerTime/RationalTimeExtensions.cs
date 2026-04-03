using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace Unity.IntegerTime
{
	public static class RationalTimeExtensions
	{
		[FreeFunction("IntegerTime::RationalTime::ConvertRate", IsFreeFunction = true, ThrowsException = true)]
		public static RationalTime Convert(this RationalTime time, RationalTime.TicksPerSecond rate)
		{
			return default(RationalTime);
		}

		private static void Convert_Injected([In] ref RationalTime time, [In] ref RationalTime.TicksPerSecond rate, out RationalTime ret)
		{
			ret = default(RationalTime);
		}
	}
}
