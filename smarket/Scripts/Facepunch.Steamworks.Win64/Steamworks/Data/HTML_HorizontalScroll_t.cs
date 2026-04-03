using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct HTML_HorizontalScroll_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal uint UnScrollMax;

		internal uint UnScrollCurrent;

		internal float FlPageScale;

		internal bool BVisible;

		internal uint UnPageSize;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
