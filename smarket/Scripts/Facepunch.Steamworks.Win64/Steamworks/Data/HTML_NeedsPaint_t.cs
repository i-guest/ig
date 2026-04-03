using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 56)]
	internal struct HTML_NeedsPaint_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal string PBGRA;

		internal uint UnWide;

		internal uint UnTall;

		internal uint UnUpdateX;

		internal uint UnUpdateY;

		internal uint UnUpdateWide;

		internal uint UnUpdateTall;

		internal uint UnScrollX;

		internal uint UnScrollY;

		internal float FlPageScale;

		internal uint UnPageSerial;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
