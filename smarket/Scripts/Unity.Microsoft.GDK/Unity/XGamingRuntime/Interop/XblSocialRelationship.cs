using System;

namespace Unity.XGamingRuntime.Interop
{
	internal struct XblSocialRelationship
	{
		internal readonly ulong xboxUserId;

		internal readonly bool isFavorite;

		internal readonly bool isFollowingCaller;

		internal readonly IntPtr socialNetworks;

		internal readonly SizeT socialNetworksCount;

		internal string[] GetSocialNetworks()
		{
			return null;
		}
	}
}
