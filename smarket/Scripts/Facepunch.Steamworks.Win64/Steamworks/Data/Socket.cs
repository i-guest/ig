namespace Steamworks.Data
{
	public struct Socket
	{
		internal uint Id;

		public SocketManager Manager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator Socket(uint value)
		{
			return default(Socket);
		}

		public static implicit operator uint(Socket value)
		{
			return 0u;
		}

		public bool Close()
		{
			return false;
		}
	}
}
