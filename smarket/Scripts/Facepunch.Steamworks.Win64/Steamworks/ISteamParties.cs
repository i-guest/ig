using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamParties : SteamInterface
	{
		public const string Version = "SteamParties002";

		internal ISteamParties(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamParties_v002();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern uint _GetNumActiveBeacons(IntPtr self);

		internal uint GetNumActiveBeacons()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern PartyBeaconID_t _GetBeaconByIndex(IntPtr self, uint unIndex);

		internal PartyBeaconID_t GetBeaconByIndex(uint unIndex)
		{
			return default(PartyBeaconID_t);
		}

		[PreserveSig]
		private static extern bool _GetBeaconDetails(IntPtr self, PartyBeaconID_t ulBeaconID, ref SteamId pSteamIDBeaconOwner, ref SteamPartyBeaconLocation_t pLocation, IntPtr pchMetadata, int cchMetadata);

		internal bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, ref SteamId pSteamIDBeaconOwner, ref SteamPartyBeaconLocation_t pLocation, out string pchMetadata)
		{
			pchMetadata = null;
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _JoinParty(IntPtr self, PartyBeaconID_t ulBeaconID);

		internal CallResult<JoinPartyCallback_t> JoinParty(PartyBeaconID_t ulBeaconID)
		{
			return default(CallResult<JoinPartyCallback_t>);
		}

		[PreserveSig]
		private static extern bool _GetNumAvailableBeaconLocations(IntPtr self, ref uint puNumLocations);

		internal bool GetNumAvailableBeaconLocations(ref uint puNumLocations)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetAvailableBeaconLocations(IntPtr self, ref SteamPartyBeaconLocation_t pLocationList, uint uMaxNumLocations);

		internal bool GetAvailableBeaconLocations(ref SteamPartyBeaconLocation_t pLocationList, uint uMaxNumLocations)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _CreateBeacon(IntPtr self, uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata);

		internal CallResult<CreateBeaconCallback_t> CreateBeacon(uint unOpenSlots, SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata)
		{
			return default(CallResult<CreateBeaconCallback_t>);
		}

		[PreserveSig]
		private static extern void _OnReservationCompleted(IntPtr self, PartyBeaconID_t ulBeacon, SteamId steamIDUser);

		internal void OnReservationCompleted(PartyBeaconID_t ulBeacon, SteamId steamIDUser)
		{
		}

		[PreserveSig]
		private static extern void _CancelReservation(IntPtr self, PartyBeaconID_t ulBeacon, SteamId steamIDUser);

		internal void CancelReservation(PartyBeaconID_t ulBeacon, SteamId steamIDUser)
		{
		}

		[PreserveSig]
		private static extern SteamAPICall_t _ChangeNumOpenSlots(IntPtr self, PartyBeaconID_t ulBeacon, uint unOpenSlots);

		internal CallResult<ChangeNumOpenSlotsCallback_t> ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots)
		{
			return default(CallResult<ChangeNumOpenSlotsCallback_t>);
		}

		[PreserveSig]
		private static extern bool _DestroyBeacon(IntPtr self, PartyBeaconID_t ulBeacon);

		internal bool DestroyBeacon(PartyBeaconID_t ulBeacon)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetBeaconLocationData(IntPtr self, SteamPartyBeaconLocation_t BeaconLocation, SteamPartyBeaconLocationData eData, IntPtr pchDataStringOut, int cchDataStringOut);

		internal bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, SteamPartyBeaconLocationData eData, out string pchDataStringOut)
		{
			pchDataStringOut = null;
			return false;
		}
	}
}
