using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblSocialManagerUser
	{
		private bool m_isFriend;

		public ulong XboxUserId { get; private set; }

		public bool IsFavorite { get; private set; }

		public bool IsFriend
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool IsFollowingUser { get; private set; }

		public bool IsFollowedByCaller { get; private set; }

		public string DisplayName { get; private set; }

		public string RealName { get; private set; }

		public string DisplayPicUrlRaw { get; private set; }

		public bool UseAvatar { get; private set; }

		public string Gamerscore { get; private set; }

		public string Gamertag { get; private set; }

		public string ModernGamertag { get; private set; }

		public string ModernGamertagSuffix { get; private set; }

		public string UniqueModernGamertag { get; private set; }

		public XblSocialManagerPresenceRecord PresenceRecord { get; private set; }

		public XblTitleHistory TitleHistory { get; private set; }

		public XblPreferredColor PreferredColor { get; private set; }

		internal XblSocialManagerUser(Unity.XGamingRuntime.Interop.XblSocialManagerUser interopUser)
		{
		}

		internal XblSocialManagerUser(XblSocialManagerUser2 interopUser)
		{
		}
	}
}
