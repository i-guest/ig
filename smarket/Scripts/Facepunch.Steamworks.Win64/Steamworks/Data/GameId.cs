using System;

namespace Steamworks.Data
{
	public struct GameId : IEquatable<GameId>
	{
		public ulong Value;

		public GameIdType Type
		{
			get
			{
				return default(GameIdType);
			}
			set
			{
			}
		}

		public uint AppId
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint ModId
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public static implicit operator GameId(ulong value)
		{
			return default(GameId);
		}

		public static implicit operator ulong(GameId value)
		{
			return 0uL;
		}

		public bool Equals(GameId other)
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

		public static bool operator ==(GameId left, GameId right)
		{
			return false;
		}

		public static bool operator !=(GameId left, GameId right)
		{
			return false;
		}
	}
}
