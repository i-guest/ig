using System;
using System.Collections.Generic;
using Steamworks.Data;

namespace Steamworks
{
	public class SocketManager
	{
		public HashSet<Connection> Connecting;

		public HashSet<Connection> Connected;

		internal HSteamNetPollGroup pollGroup;

		public ISocketManager Interface { get; set; }

		public Socket Socket { get; internal set; }

		public override string ToString()
		{
			return null;
		}

		internal void Initialize()
		{
		}

		public bool Close()
		{
			return false;
		}

		public virtual void OnConnectionChanged(Connection connection, ConnectionInfo info)
		{
		}

		public virtual void OnConnecting(Connection connection, ConnectionInfo info)
		{
		}

		public virtual void OnConnected(Connection connection, ConnectionInfo info)
		{
		}

		public virtual void OnDisconnected(Connection connection, ConnectionInfo info)
		{
		}

		public int Receive(int bufferSize = 32, bool receiveToEnd = true)
		{
			return 0;
		}

		internal void ReceiveMessage(IntPtr msgPtr)
		{
		}

		public virtual void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel)
		{
		}
	}
}
