using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblSocialRelationship
	{
		private bool m_isFriend;

		public ulong XboxUserId { get; }

		public bool IsFavourite { get; }

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

		public bool IsFollowingCaller { get; }

		public string[] SocialNetworks { get; }

		internal XblSocialRelationship(Unity.XGamingRuntime.Interop.XblSocialRelationship interopHandle)
		{
		}

		internal XblSocialRelationship(XblSocialRelationship2 interopHandle)
		{
		}
	}
}
