using System;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamNetworking : SteamSharedClass<SteamNetworking>
	{
		public static Action<SteamId> OnP2PSessionRequest;

		public static Action<SteamId, P2PSessionError> OnP2PConnectionFailed;

		internal static ISteamNetworking Internal => null;

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}

		internal static void InstallEvents(bool server)
		{
		}

		public static bool AcceptP2PSessionWithUser(SteamId user)
		{
			return false;
		}

		public static bool AllowP2PPacketRelay(bool allow)
		{
			return false;
		}

		public static bool CloseP2PSessionWithUser(SteamId user)
		{
			return false;
		}

		public static bool IsP2PPacketAvailable(int channel = 0)
		{
			return false;
		}

		public static bool IsP2PPacketAvailable(out uint msgSize, int channel = 0)
		{
			msgSize = default(uint);
			return false;
		}

		public static P2Packet? ReadP2PPacket(int channel = 0)
		{
			return null;
		}

		public static bool ReadP2PPacket(byte[] buffer, ref uint size, ref SteamId steamid, int channel = 0)
		{
			return false;
		}

		public unsafe static bool ReadP2PPacket(byte* buffer, uint cbuf, ref uint size, ref SteamId steamid, int channel = 0)
		{
			return false;
		}

		public static bool SendP2PPacket(SteamId steamid, byte[] data, int length = -1, int nChannel = 0, P2PSend sendType = P2PSend.Reliable)
		{
			return false;
		}

		public unsafe static bool SendP2PPacket(SteamId steamid, byte* data, uint length, int nChannel = 1, P2PSend sendType = P2PSend.Reliable)
		{
			return false;
		}
	}
}
