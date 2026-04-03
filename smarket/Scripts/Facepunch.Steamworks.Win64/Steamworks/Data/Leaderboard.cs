using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Steamworks.Data
{
	public struct Leaderboard
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAttachUgc_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Result> _003C_003Et__builder;

			public Leaderboard _003C_003E4__this;

			public Ugc file;

			private CallResult<LeaderboardUGCSet_t> _003C_003Eu__1;

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
		private struct _003CGetScoresAroundUserAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardEntry[]> _003C_003Et__builder;

			public Leaderboard _003C_003E4__this;

			public int start;

			public int end;

			private CallResult<LeaderboardScoresDownloaded_t> _003C_003Eu__1;

			private TaskAwaiter<LeaderboardEntry[]> _003C_003Eu__2;

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
		private struct _003CGetScoresAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardEntry[]> _003C_003Et__builder;

			public int offset;

			public Leaderboard _003C_003E4__this;

			public int count;

			private CallResult<LeaderboardScoresDownloaded_t> _003C_003Eu__1;

			private TaskAwaiter<LeaderboardEntry[]> _003C_003Eu__2;

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
		private struct _003CGetScoresForUsersAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardEntry[]> _003C_003Et__builder;

			public SteamId[] users;

			public Leaderboard _003C_003E4__this;

			private CallResult<LeaderboardScoresDownloaded_t> _003C_003Eu__1;

			private TaskAwaiter<LeaderboardEntry[]> _003C_003Eu__2;

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
		private struct _003CGetScoresFromFriendsAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardEntry[]> _003C_003Et__builder;

			public Leaderboard _003C_003E4__this;

			private CallResult<LeaderboardScoresDownloaded_t> _003C_003Eu__1;

			private TaskAwaiter<LeaderboardEntry[]> _003C_003Eu__2;

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
		private struct _003CLeaderboardResultToEntries_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardEntry[]> _003C_003Et__builder;

			public LeaderboardScoresDownloaded_t r;

			public Leaderboard _003C_003E4__this;

			private LeaderboardEntry[] _003Coutput_003E5__2;

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
		private struct _003CReplaceScore_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardUpdate?> _003C_003Et__builder;

			public int[] details;

			public Leaderboard _003C_003E4__this;

			public int score;

			private CallResult<LeaderboardScoreUploaded_t> _003C_003Eu__1;

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
		private struct _003CSubmitScoreAsync_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardUpdate?> _003C_003Et__builder;

			public int[] details;

			public Leaderboard _003C_003E4__this;

			public int score;

			private CallResult<LeaderboardScoreUploaded_t> _003C_003Eu__1;

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
		private struct _003CWaitForUserNames_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public LeaderboardEntry[] entries;

			private bool _003CgotAll_003E5__2;

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

		internal SteamLeaderboard_t Id;

		private static int[] detailsBuffer;

		private static int[] noDetails;

		public string Name => null;

		public LeaderboardSort Sort => default(LeaderboardSort);

		public LeaderboardDisplay Display => default(LeaderboardDisplay);

		public int EntryCount => 0;

		[AsyncStateMachine(typeof(_003CReplaceScore_003Ed__11))]
		public Task<LeaderboardUpdate?> ReplaceScore(int score, int[] details = null)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSubmitScoreAsync_003Ed__12))]
		public Task<LeaderboardUpdate?> SubmitScoreAsync(int score, int[] details = null)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAttachUgc_003Ed__13))]
		public Task<Result> AttachUgc(Ugc file)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetScoresForUsersAsync_003Ed__14))]
		public Task<LeaderboardEntry[]> GetScoresForUsersAsync(SteamId[] users)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetScoresAsync_003Ed__15))]
		public Task<LeaderboardEntry[]> GetScoresAsync(int count, int offset = 1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetScoresAroundUserAsync_003Ed__16))]
		public Task<LeaderboardEntry[]> GetScoresAroundUserAsync(int start = -10, int end = 10)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetScoresFromFriendsAsync_003Ed__17))]
		public Task<LeaderboardEntry[]> GetScoresFromFriendsAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLeaderboardResultToEntries_003Ed__18))]
		internal Task<LeaderboardEntry[]> LeaderboardResultToEntries(LeaderboardScoresDownloaded_t r)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWaitForUserNames_003Ed__19))]
		internal static Task WaitForUserNames(LeaderboardEntry[] entries)
		{
			return null;
		}
	}
}
