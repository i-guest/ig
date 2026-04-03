using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 2572)]
	internal struct GetTicketForWebApiResponse_t : ICallbackData
	{
		internal uint AuthTicket;

		internal Result Result;

		internal int Ticket;

		internal byte[] GubTicket;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
