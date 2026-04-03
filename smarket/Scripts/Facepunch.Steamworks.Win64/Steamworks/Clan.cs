using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public struct Clan
	{
		[CompilerGenerated]
		private sealed class _003CGetOfficers_003Ed__15 : IEnumerable<Friend>, IEnumerable, IEnumerator<Friend>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Friend _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Clan _003C_003E4__this;

			public Clan _003C_003E3___003C_003E4__this;

			private int _003Ci_003E5__2;

			Friend IEnumerator<Friend>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(Friend);
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
			public _003CGetOfficers_003Ed__15(int _003C_003E1__state)
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
			IEnumerator<Friend> IEnumerable<Friend>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestOfficerList_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Clan _003C_003E4__this;

			private CallResult<ClanOfficerListResponse_t> _003C_003Eu__1;

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

		public SteamId Id;

		public string Name => null;

		public string Tag => null;

		public int ChatMemberCount => 0;

		public Friend Owner => default(Friend);

		public bool Public => false;

		public bool Official => false;

		public Clan(SteamId id)
		{
			Id = default(SteamId);
		}

		[AsyncStateMachine(typeof(_003CRequestOfficerList_003Ed__14))]
		public Task<bool> RequestOfficerList()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetOfficers_003Ed__15))]
		public IEnumerable<Friend> GetOfficers()
		{
			return null;
		}
	}
}
