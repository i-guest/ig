using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 144)]
	internal struct GSClientAchievementStatus_t : ICallbackData
	{
		internal ulong SteamID;

		internal byte[] PchAchievement;

		internal bool Unlocked;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string PchAchievementUTF8()
		{
			return null;
		}
	}
}
