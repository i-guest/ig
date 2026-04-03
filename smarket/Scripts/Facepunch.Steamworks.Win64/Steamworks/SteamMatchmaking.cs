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
	public class SteamMatchmaking : SteamClientClass<SteamMatchmaking>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateLobbyAsync_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Lobby?> _003C_003Et__builder;

			public int maxMembers;

			private CallResult<LobbyCreated_t> _003C_003Eu__1;

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
		private sealed class _003CGetFavoriteServers_003Ed__47 : IEnumerable<ServerInfo>, IEnumerable, IEnumerator<ServerInfo>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private ServerInfo _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int _003Ccount_003E5__2;

			private int _003Ci_003E5__3;

			ServerInfo IEnumerator<ServerInfo>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(ServerInfo);
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
			public _003CGetFavoriteServers_003Ed__47(int _003C_003E1__state)
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
			IEnumerator<ServerInfo> IEnumerable<ServerInfo>.GetEnumerator()
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
		private sealed class _003CGetHistoryServers_003Ed__48 : IEnumerable<ServerInfo>, IEnumerable, IEnumerator<ServerInfo>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private ServerInfo _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int _003Ccount_003E5__2;

			private int _003Ci_003E5__3;

			ServerInfo IEnumerator<ServerInfo>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(ServerInfo);
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
			public _003CGetHistoryServers_003Ed__48(int _003C_003E1__state)
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
			IEnumerator<ServerInfo> IEnumerable<ServerInfo>.GetEnumerator()
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
		private struct _003CJoinLobbyAsync_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Lobby?> _003C_003Et__builder;

			public SteamId lobbyId;

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

		internal static ISteamMatchmaking Internal => null;

		internal static int MaxLobbyKeyLength => 0;

		public static LobbyQuery LobbyList => default(LobbyQuery);

		public static event Action<Friend, Lobby> OnLobbyInvite
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

		public static event Action<Lobby> OnLobbyEntered
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

		public static event Action<Result, Lobby> OnLobbyCreated
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

		public static event Action<Lobby, uint, ushort, SteamId> OnLobbyGameCreated
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

		public static event Action<Lobby> OnLobbyDataChanged
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

		public static event Action<Lobby, Friend> OnLobbyMemberDataChanged
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

		public static event Action<Lobby, Friend> OnLobbyMemberJoined
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

		public static event Action<Lobby, Friend> OnLobbyMemberLeave
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

		public static event Action<Lobby, Friend> OnLobbyMemberDisconnected
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

		public static event Action<Lobby, Friend, Friend> OnLobbyMemberKicked
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

		public static event Action<Lobby, Friend, Friend> OnLobbyMemberBanned
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

		public static event Action<Lobby, Friend, string> OnChatMessage
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

		internal static void InstallEvents()
		{
		}

		private static void OnLobbyChatMessageRecievedAPI(LobbyChatMsg_t callback)
		{
		}

		[AsyncStateMachine(typeof(_003CCreateLobbyAsync_003Ed__45))]
		public static Task<Lobby?> CreateLobbyAsync(int maxMembers = 100)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CJoinLobbyAsync_003Ed__46))]
		public static Task<Lobby?> JoinLobbyAsync(SteamId lobbyId)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetFavoriteServers_003Ed__47))]
		public static IEnumerable<ServerInfo> GetFavoriteServers()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetHistoryServers_003Ed__48))]
		public static IEnumerable<ServerInfo> GetHistoryServers()
		{
			return null;
		}
	}
}
