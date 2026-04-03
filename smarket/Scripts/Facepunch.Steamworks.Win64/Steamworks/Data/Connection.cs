using System;

namespace Steamworks.Data
{
	public struct Connection : IEquatable<Connection>
	{
		public uint Id { get; set; }

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

		public bool Equals(Connection other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator Connection(uint value)
		{
			return default(Connection);
		}

		public static implicit operator uint(Connection value)
		{
			return 0u;
		}

		public static bool operator ==(Connection value1, Connection value2)
		{
			return false;
		}

		public static bool operator !=(Connection value1, Connection value2)
		{
			return false;
		}

		public Result Accept()
		{
			return default(Result);
		}

		public bool Close(bool linger = false, int reasonCode = 0, string debugString = "Closing Connection")
		{
			return false;
		}

		public Result SendMessage(IntPtr ptr, int size, SendType sendType = SendType.Reliable, ushort laneIndex = 0)
		{
			return default(Result);
		}

		public Result SendMessage(byte[] data, SendType sendType = SendType.Reliable, ushort laneIndex = 0)
		{
			return default(Result);
		}

		public Result SendMessage(byte[] data, int offset, int length, SendType sendType = SendType.Reliable, ushort laneIndex = 0)
		{
			return default(Result);
		}

		public Result SendMessage(string str, SendType sendType = SendType.Reliable, ushort laneIndex = 0)
		{
			return default(Result);
		}

		public Result Flush()
		{
			return default(Result);
		}

		public string DetailedStatus()
		{
			return null;
		}

		public ConnectionStatus QuickStatus()
		{
			return default(ConnectionStatus);
		}

		public Result ConfigureConnectionLanes(int[] lanePriorities, ushort[] laneWeights)
		{
			return default(Result);
		}
	}
}
