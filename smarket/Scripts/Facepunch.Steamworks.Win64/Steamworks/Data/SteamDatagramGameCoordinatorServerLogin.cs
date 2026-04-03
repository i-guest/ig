using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 2328)]
	internal struct SteamDatagramGameCoordinatorServerLogin
	{
		internal NetIdentity Dentity;

		internal SteamDatagramHostedAddress Outing;

		internal AppId AppID;

		internal uint Time;

		internal int CbAppData;

		internal byte[] AppData;

		internal string AppDataUTF8()
		{
			return null;
		}
	}
}
