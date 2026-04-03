using System;

namespace Steamworks
{
	public class AuthTicket : IDisposable
	{
		public byte[] Data;

		public uint Handle;

		public void Cancel()
		{
		}

		public void Dispose()
		{
		}
	}
}
