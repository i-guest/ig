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
	public class SteamFriends : SteamClientClass<SteamFriends>
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass64_0
		{
			public List<SteamId> steamIds;

			internal void _003CGetFollowingList_003Eb__0(ulong id)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCacheUserInformationAsync_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public SteamId steamid;

			public bool nameonly;

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

		[CompilerGenerated]
		private sealed class _003CGetClans_003Ed__43 : IEnumerable<Clan>, IEnumerable, IEnumerator<Clan>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Clan _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int _003Ci_003E5__2;

			Clan IEnumerator<Clan>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(Clan);
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
			public _003CGetClans_003Ed__43(int _003C_003E1__state)
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
			IEnumerator<Clan> IEnumerable<Clan>.GetEnumerator()
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
		private struct _003CGetFollowerCount_003Ed__63 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			public SteamId steamID;

			private CallResult<FriendsGetFollowerCount_t> _003C_003Eu__1;

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
		private struct _003CGetFollowingList_003Ed__64 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<SteamId[]> _003C_003Et__builder;

			private _003C_003Ec__DisplayClass64_0 _003C_003E8__1;

			private int _003CresultCount_003E5__2;

			private CallResult<FriendsEnumerateFollowingList_t> _003C_003Eu__1;

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
		private sealed class _003CGetFriendsWithFlag_003Ed__34 : IEnumerable<Friend>, IEnumerable, IEnumerator<Friend>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Friend _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private FriendFlags flag;

			public FriendFlags _003C_003E3__flag;

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
			public _003CGetFriendsWithFlag_003Ed__34(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CGetFromSource_003Ed__42 : IEnumerable<Friend>, IEnumerable, IEnumerator<Friend>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Friend _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private SteamId steamid;

			public SteamId _003C_003E3__steamid;

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
			public _003CGetFromSource_003Ed__42(int _003C_003E1__state)
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
		private struct _003CGetLargeAvatarAsync_003Ed__54 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Image?> _003C_003Et__builder;

			public SteamId steamid;

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
		private struct _003CGetMediumAvatarAsync_003Ed__53 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Image?> _003C_003Et__builder;

			public SteamId steamid;

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

		[CompilerGenerated]
		private sealed class _003CGetPlayedWith_003Ed__41 : IEnumerable<Friend>, IEnumerable, IEnumerator<Friend>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Friend _003C_003E2__current;

			private int _003C_003El__initialThreadId;

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
			public _003CGetPlayedWith_003Ed__41(int _003C_003E1__state)
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
		private struct _003CGetSmallAvatarAsync_003Ed__52 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Image?> _003C_003Et__builder;

			public SteamId steamid;

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
		private struct _003CIsFollowing_003Ed__62 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public SteamId steamID;

			private CallResult<FriendsIsFollowing_t> _003C_003Eu__1;

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
		private struct _003CJoinClanChatRoom_003Ed__66 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public SteamId chatId;

			private CallResult<JoinClanChatRoomCompletionResult_t> _003C_003Eu__1;

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

		private static Dictionary<string, string> richPresence;

		private static bool _listenForFriendsMessages;

		internal static ISteamFriends Internal => null;

		public static bool ListenForFriendsMessages
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static event Action<Friend, string, string> OnChatMessage
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

		public static event Action<Friend, string, string> OnClanChatMessage
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

		public static event Action<Friend> OnPersonaStateChange
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

		public static event Action<Friend, string> OnGameRichPresenceJoinRequested
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

		public static event Action<bool> OnGameOverlayActivated
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

		public static event Action<string, string> OnGameServerChangeRequested
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

		public static event Action<Lobby, SteamId> OnGameLobbyJoinRequested
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

		public static event Action<Friend> OnFriendRichPresenceUpdate
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

		public static event Action<string> OnOverlayBrowserProtocol
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

		internal void InstallEvents()
		{
		}

		private static void OnFriendChatMessage(GameConnectedFriendChatMsg_t data)
		{
		}

		private static void OnGameConnectedClanChatMessage(GameConnectedClanChatMsg_t data)
		{
		}

		[IteratorStateMachine(typeof(_003CGetFriendsWithFlag_003Ed__34))]
		private static IEnumerable<Friend> GetFriendsWithFlag(FriendFlags flag)
		{
			return null;
		}

		public static IEnumerable<Friend> GetFriends()
		{
			return null;
		}

		public static IEnumerable<Friend> GetBlocked()
		{
			return null;
		}

		public static IEnumerable<Friend> GetFriendsRequested()
		{
			return null;
		}

		public static IEnumerable<Friend> GetFriendsClanMembers()
		{
			return null;
		}

		public static IEnumerable<Friend> GetFriendsOnGameServer()
		{
			return null;
		}

		public static IEnumerable<Friend> GetFriendsRequestingFriendship()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetPlayedWith_003Ed__41))]
		public static IEnumerable<Friend> GetPlayedWith()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetFromSource_003Ed__42))]
		public static IEnumerable<Friend> GetFromSource(SteamId steamid)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetClans_003Ed__43))]
		public static IEnumerable<Clan> GetClans()
		{
			return null;
		}

		public static void OpenOverlay(string type)
		{
		}

		public static void OpenUserOverlay(SteamId id, string type)
		{
		}

		public static void OpenStoreOverlay(AppId id, OverlayToStoreFlag overlayToStoreFlag = OverlayToStoreFlag.None)
		{
		}

		public static void OpenWebOverlay(string url, bool modal = false)
		{
		}

		public static void OpenGameInviteOverlay(SteamId lobby)
		{
		}

		public static void SetPlayedWith(SteamId steamid)
		{
		}

		public static bool RequestUserInformation(SteamId steamid, bool nameonly = true)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CCacheUserInformationAsync_003Ed__51))]
		internal static Task CacheUserInformationAsync(SteamId steamid, bool nameonly)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetSmallAvatarAsync_003Ed__52))]
		public static Task<Image?> GetSmallAvatarAsync(SteamId steamid)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetMediumAvatarAsync_003Ed__53))]
		public static Task<Image?> GetMediumAvatarAsync(SteamId steamid)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetLargeAvatarAsync_003Ed__54))]
		public static Task<Image?> GetLargeAvatarAsync(SteamId steamid)
		{
			return null;
		}

		public static string GetRichPresence(string key)
		{
			return null;
		}

		public static bool SetRichPresence(string key, string value)
		{
			return false;
		}

		public static void ClearRichPresence()
		{
		}

		[AsyncStateMachine(typeof(_003CIsFollowing_003Ed__62))]
		public static Task<bool> IsFollowing(SteamId steamID)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetFollowerCount_003Ed__63))]
		public static Task<int> GetFollowerCount(SteamId steamID)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetFollowingList_003Ed__64))]
		public static Task<SteamId[]> GetFollowingList()
		{
			return null;
		}

		public static bool RegisterProtocolInOverlayBrowser(string protocol)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CJoinClanChatRoom_003Ed__66))]
		public static Task<bool> JoinClanChatRoom(SteamId chatId)
		{
			return null;
		}

		public static bool SendClanChatRoomMessage(SteamId chatId, string message)
		{
			return false;
		}
	}
}
