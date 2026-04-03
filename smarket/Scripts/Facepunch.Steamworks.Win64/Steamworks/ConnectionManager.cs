using System;
using Steamworks.Data;

namespace Steamworks
{
	public class ConnectionManager
	{
		public Connection Connection;

		public bool Connected;

		public bool Connecting;

		public IConnectionManager Interface { get; set; }

		public ConnectionInfo ConnectionInfo { get; internal set; }

		public string ConnectionName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long UserData
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public void Close(bool linger = false, int reasonCode = 0, string debugString = "Closing Connection")
		{
		}

		public override string ToString()
		{
			return null;
		}

		public virtual void OnConnectionChanged(ConnectionInfo info)
		{
		}

		public virtual void OnConnecting(ConnectionInfo info)
		{
		}

		public virtual void OnConnected(ConnectionInfo info)
		{
		}

		public virtual void OnDisconnected(ConnectionInfo info)
		{
		}

		public int Receive(int bufferSize = 32, bool receiveToEnd = true)
		{
			return 0;
		}

		public void SendMessages(Connection[] connections, int connectionCount, IntPtr ptr, int size, SendType sendType = SendType.Reliable, Result[] results = null)
		{
		}

		public void SendMessages(Connection[] connections, int connectionCount, byte[] data, SendType sendType = SendType.Reliable, Result[] results = null)
		{
		}

		public void SendMessages(Connection[] connections, int connectionCount, byte[] data, int offset, int length, SendType sendType = SendType.Reliable, Result[] results = null)
		{
		}

		public void SendMessages(Connection[] connections, int connectionCount, string str, SendType sendType = SendType.Reliable, Result[] results = null)
		{
		}

		internal unsafe void ReceiveMessage(ref NetMsg* msg)
		{
		}

		public virtual void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel)
		{
		}
	}
}
