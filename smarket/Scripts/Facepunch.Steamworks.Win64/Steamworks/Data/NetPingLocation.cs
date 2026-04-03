using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)2, Size = 512)]
	public struct NetPingLocation
	{
		public static NetPingLocation? TryParseFromString(string str)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public int EstimatePingTo(NetPingLocation target)
		{
			return 0;
		}
	}
}
