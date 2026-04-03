using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public struct PartyBeacon
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CJoinAsync_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public PartyBeacon _003C_003E4__this;

			private CallResult<JoinPartyCallback_t> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		internal PartyBeaconID_t Id;

		private static ISteamParties Internal => null;

		public SteamId Owner => default(SteamId);

		public string MetaData => null;

		[AsyncStateMachine(typeof(_003CJoinAsync_003Ed__7))]
		public Task<string> JoinAsync()
		{
			return null;
		}

		public void OnReservationCompleted(SteamId steamid)
		{
		}

		public void CancelReservation(SteamId steamid)
		{
		}

		public bool Destroy()
		{
			return false;
		}
	}
}
