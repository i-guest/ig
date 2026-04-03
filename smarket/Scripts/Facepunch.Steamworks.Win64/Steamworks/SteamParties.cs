using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Steamworks
{
	public class SteamParties : SteamClientClass<SteamParties>
	{
		[CompilerGenerated]
		private sealed class _003Cget_ActiveBeacons_003Ed__13 : IEnumerable<PartyBeacon>, IEnumerable, IEnumerator<PartyBeacon>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private PartyBeacon _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private uint _003Ci_003E5__2;

			PartyBeacon IEnumerator<PartyBeacon>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(PartyBeacon);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_ActiveBeacons_003Ed__13(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<PartyBeacon> IEnumerable<PartyBeacon>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal static ISteamParties Internal => null;

		public static int ActiveBeaconCount => 0;

		public static IEnumerable<PartyBeacon> ActiveBeacons
		{
			[IteratorStateMachine(typeof(_003Cget_ActiveBeacons_003Ed__13))]
			get
			{
				return null;
			}
		}

		public static event Action OnBeaconLocationsUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnActiveBeaconsUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}

		internal void InstallEvents(bool server)
		{
		}
	}
}
