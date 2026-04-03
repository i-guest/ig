using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerSessionCapabilities
	{
		public bool Connectivity { get; }

		public bool Team { get; }

		public bool Arbitration { get; }

		public bool SuppressPresenceActivityCheck { get; }

		public bool Gameplay { get; }

		public bool Large { get; }

		public bool ConnectionRequiredForActiveMembers { get; }

		public bool UserAuthorizationStyle { get; }

		public bool Crossplay { get; }

		public bool Searchable { get; }

		public bool HasOwners { get; }

		internal XblMultiplayerSessionCapabilities(Unity.XGamingRuntime.Interop.XblMultiplayerSessionCapabilities interopStruct)
		{
		}
	}
}
