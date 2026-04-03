using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public struct Friend
	{
		public struct FriendGameInfo
		{
			internal uint GameIP;

			internal ulong SteamIDLobby;

			public GameId GameID;

			public int ConnectionPort;

			public int QueryPort;

			public uint IpAddressRaw => 0u;

			public IPAddress IpAddress => null;

			public Lobby? Lobby => null;

			internal static FriendGameInfo From(FriendGameInfo_t i)
			{
				return default(FriendGameInfo);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetLargeAvatarAsync_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Image?> _003C_003Et__builder;

			public Friend _003C_003E4__this;

			private TaskAwaiter<Image?> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetMediumAvatarAsync_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Image?> _003C_003Et__builder;

			public Friend _003C_003E4__this;

			private TaskAwaiter<Image?> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetSmallAvatarAsync_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Image?> _003C_003Et__builder;

			public Friend _003C_003E4__this;

			private TaskAwaiter<Image?> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestInfoAsync_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Friend _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestUserStatsAsync_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Friend _003C_003E4__this;

			private CallResult<UserStatsReceived_t> _003C_003Eu__1;

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
		private sealed class _003Cget_NameHistory_003Ed__29 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Friend _003C_003E4__this;

			public Friend _003C_003E3___003C_003E4__this;

			private int _003Ci_003E5__2;

			string IEnumerator<string>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003Cget_NameHistory_003Ed__29(int _003C_003E1__state)
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
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public SteamId Id;

		public bool IsMe => false;

		public bool IsFriend => false;

		public bool IsBlocked => false;

		public bool IsPlayingThisGame => false;

		public bool IsOnline => false;

		public bool IsAway => false;

		public bool IsBusy => false;

		public bool IsSnoozing => false;

		public Relationship Relationship => default(Relationship);

		public FriendState State => default(FriendState);

		public string Name => null;

		public string Nickname => null;

		public IEnumerable<string> NameHistory
		{
			[IteratorStateMachine(typeof(_003Cget_NameHistory_003Ed__29))]
			get
			{
				return null;
			}
		}

		public int SteamLevel => 0;

		public FriendGameInfo? GameInfo => null;

		public Friend(SteamId steamid)
		{
			Id = default(SteamId);
		}

		public override string ToString()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestInfoAsync_003Ed__13))]
		public Task RequestInfoAsync()
		{
			return null;
		}

		public bool IsIn(SteamId group_or_room)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CGetSmallAvatarAsync_003Ed__36))]
		public Task<Image?> GetSmallAvatarAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetMediumAvatarAsync_003Ed__37))]
		public Task<Image?> GetMediumAvatarAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetLargeAvatarAsync_003Ed__38))]
		public Task<Image?> GetLargeAvatarAsync()
		{
			return null;
		}

		public string GetRichPresence(string key)
		{
			return null;
		}

		public bool InviteToGame(string Text)
		{
			return false;
		}

		public bool SendMessage(string message)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CRequestUserStatsAsync_003Ed__42))]
		public Task<bool> RequestUserStatsAsync()
		{
			return null;
		}

		public float GetStatFloat(string statName, float defult = 0f)
		{
			return 0f;
		}

		public int GetStatInt(string statName, int defult = 0)
		{
			return 0;
		}

		public bool GetAchievement(string statName, bool defult = false)
		{
			return false;
		}

		public DateTime GetAchievementUnlockTime(string statName)
		{
			return default(DateTime);
		}
	}
}
