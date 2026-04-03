using System;

namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerSessionInitArgs
	{
		internal readonly uint MaxMembersInSession;

		internal readonly XblMultiplayerSessionVisibility Visibility;

		private readonly IntPtr InitiatorXuids;

		internal readonly SizeT InitiatorXuidsCount;

		internal readonly UTF8StringPtr CustomJson;

		internal XblMultiplayerSessionInitArgs(Unity.XGamingRuntime.XblMultiplayerSessionInitArgs publicObject, DisposableCollection disposableCollection)
		{
			MaxMembersInSession = 0u;
			Visibility = default(XblMultiplayerSessionVisibility);
			InitiatorXuids = (IntPtr)0;
			InitiatorXuidsCount = default(SizeT);
			CustomJson = default(UTF8StringPtr);
		}
	}
}
