using System.Runtime.InteropServices;

namespace Unity.XGamingRuntime.Interop
{
	public static class XboxLiveGlobal
	{
		[PreserveSig]
		public unsafe static extern int XblGetScid(sbyte** scid);
	}
}
