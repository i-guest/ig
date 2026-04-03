using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 20)]
	internal struct EquippedProfileItems_t : ICallbackData
	{
		internal Result Result;

		internal ulong SteamID;

		internal bool HasAnimatedAvatar;

		internal bool HasAvatarFrame;

		internal bool HasProfileModifier;

		internal bool HasProfileBackground;

		internal bool HasMiniProfileBackground;

		internal bool FromCache;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
