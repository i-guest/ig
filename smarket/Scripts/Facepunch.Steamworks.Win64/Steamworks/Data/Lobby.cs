using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Steamworks.Data
{
	public struct Lobby
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CJoin_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<RoomEnter> _003C_003Et__builder;

			public Lobby _003C_003E4__this;

			private CallResult<LobbyEnter_t> _003C_003Eu__1;

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

		[CompilerGenerated]
		private sealed class _003Cget_Data_003Ed__16 : IEnumerable<KeyValuePair<string, string>>, IEnumerable, IEnumerator<KeyValuePair<string, string>>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private KeyValuePair<string, string> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Lobby _003C_003E4__this;

			public Lobby _003C_003E3___003C_003E4__this;

			private int _003Ccnt_003E5__2;

			private int _003Ci_003E5__3;

			KeyValuePair<string, string> IEnumerator<KeyValuePair<string, string>>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, string>);
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
			public _003Cget_Data_003Ed__16(int _003C_003E1__state)
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
			IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_Members_003Ed__11 : IEnumerable<Friend>, IEnumerable, IEnumerator<Friend>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Friend _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Lobby _003C_003E4__this;

			public Lobby _003C_003E3___003C_003E4__this;

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
			public _003Cget_Members_003Ed__11(int _003C_003E1__state)
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

		public SteamId Id { get; internal set; }

		public int MemberCount => 0;

		public IEnumerable<Friend> Members
		{
			[IteratorStateMachine(typeof(_003Cget_Members_003Ed__11))]
			get
			{
				return null;
			}
		}

		public IEnumerable<KeyValuePair<string, string>> Data
		{
			[IteratorStateMachine(typeof(_003Cget_Data_003Ed__16))]
			get
			{
				return null;
			}
		}

		public int MaxMembers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Friend Owner
		{
			get
			{
				return default(Friend);
			}
			set
			{
			}
		}

		public Lobby(SteamId id)
		{
			Id = default(SteamId);
		}

		[AsyncStateMachine(typeof(_003CJoin_003Ed__5))]
		public Task<RoomEnter> Join()
		{
			return null;
		}

		public void Leave()
		{
		}

		public bool InviteFriend(SteamId steamid)
		{
			return false;
		}

		public string GetData(string key)
		{
			return null;
		}

		public bool SetData(string key, string value)
		{
			return false;
		}

		public bool DeleteData(string key)
		{
			return false;
		}

		public string GetMemberData(Friend member, string key)
		{
			return null;
		}

		public void SetMemberData(string key, string value)
		{
		}

		public bool SendChatString(string message)
		{
			return false;
		}

		public bool SendChatBytes(byte[] data)
		{
			return false;
		}

		public unsafe bool SendChatBytesUnsafe(byte* ptr, int length)
		{
			return false;
		}

		public bool Refresh()
		{
			return false;
		}

		public bool SetPublic()
		{
			return false;
		}

		public bool SetPrivate()
		{
			return false;
		}

		public bool SetInvisible()
		{
			return false;
		}

		public bool SetFriendsOnly()
		{
			return false;
		}

		public bool SetJoinable(bool b)
		{
			return false;
		}

		public void SetGameServer(SteamId steamServer)
		{
		}

		public void SetGameServer(string ip, ushort port)
		{
		}

		public bool GetGameServer(ref uint ip, ref ushort port, ref SteamId serverId)
		{
			return false;
		}

		public bool IsOwnedBy(SteamId k)
		{
			return false;
		}
	}
}
