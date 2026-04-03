using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 152)]
	internal struct UserAchievementStored_t : ICallbackData
	{
		internal ulong GameID;

		internal bool GroupAchievement;

		internal byte[] AchievementName;

		internal uint CurProgress;

		internal uint MaxProgress;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string AchievementNameUTF8()
		{
			return null;
		}
	}
}
