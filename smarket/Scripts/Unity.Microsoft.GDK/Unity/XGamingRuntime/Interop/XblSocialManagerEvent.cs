using System;

namespace Unity.XGamingRuntime.Interop
{
	internal struct XblSocialManagerEvent
	{
		internal readonly IntPtr user;

		internal readonly XblSocialManagerEventType eventType;

		internal readonly int hr;

		internal readonly XblSocialManagerUserGroupHandle loadedGroup;

		internal readonly IntPtr[] usersAffected;

		internal XblSocialManagerUser[] GetUserArray()
		{
			return null;
		}
	}
}
