using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 144)]
	internal struct UserAchievementIconFetched_t : ICallbackData
	{
		internal GameId GameID;

		internal byte[] AchievementName;

		internal bool Achieved;

		internal int IconHandle;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string AchievementNameUTF8()
		{
			return null;
		}
	}
}
