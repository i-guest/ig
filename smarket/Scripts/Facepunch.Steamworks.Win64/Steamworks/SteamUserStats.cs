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
	public class SteamUserStats : SteamClientClass<SteamUserStats>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFindLeaderboardAsync_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Leaderboard?> _003C_003Et__builder;

			public string name;

			private CallResult<LeaderboardFindResult_t> _003C_003Eu__1;

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
		private struct _003CFindOrCreateLeaderboardAsync_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Leaderboard?> _003C_003Et__builder;

			public string name;

			public LeaderboardSort sort;

			public LeaderboardDisplay display;

			private CallResult<LeaderboardFindResult_t> _003C_003Eu__1;

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
		private struct _003CPlayerCountAsync_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			private CallResult<NumberOfCurrentPlayers_t> _003C_003Eu__1;

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
		private struct _003CRequestGlobalStatsAsync_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Result> _003C_003Et__builder;

			public int days;

			private CallResult<GlobalStatsReceived_t> _003C_003Eu__1;

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
		private sealed class _003Cget_Achievements_003Ed__24 : IEnumerable<Achievement>, IEnumerable, IEnumerator<Achievement>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Achievement _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int _003Ci_003E5__2;

			Achievement IEnumerator<Achievement>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(Achievement);
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
			public _003Cget_Achievements_003Ed__24(int _003C_003E1__state)
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
			IEnumerator<Achievement> IEnumerable<Achievement>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal static ISteamUserStats Internal => null;

		public static bool StatsRecieved { get; internal set; }

		public static IEnumerable<Achievement> Achievements
		{
			[IteratorStateMachine(typeof(_003Cget_Achievements_003Ed__24))]
			get
			{
				return null;
			}
		}

		internal static event Action<string, int> OnAchievementIconFetched
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

		public static event Action<SteamId, Result> OnUserStatsReceived
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

		public static event Action<Result> OnUserStatsStored
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

		public static event Action<Achievement, int, int> OnAchievementProgress
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

		public static event Action<SteamId> OnUserStatsUnloaded
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

		public static bool IndicateAchievementProgress(string achName, int curProg, int maxProg)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CPlayerCountAsync_003Ed__26))]
		public static Task<int> PlayerCountAsync()
		{
			return null;
		}

		public static bool StoreStats()
		{
			return false;
		}

		[Obsolete("No longer required. Automatically handled by the Steam client.", false)]
		public static bool RequestCurrentStats()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CRequestGlobalStatsAsync_003Ed__29))]
		public static Task<Result> RequestGlobalStatsAsync(int days)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFindOrCreateLeaderboardAsync_003Ed__30))]
		public static Task<Leaderboard?> FindOrCreateLeaderboardAsync(string name, LeaderboardSort sort, LeaderboardDisplay display)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFindLeaderboardAsync_003Ed__31))]
		public static Task<Leaderboard?> FindLeaderboardAsync(string name)
		{
			return null;
		}

		public static bool AddStat(string name, int amount = 1)
		{
			return false;
		}

		public static bool AddStat(string name, float amount = 1f)
		{
			return false;
		}

		public static bool SetStat(string name, int value)
		{
			return false;
		}

		public static bool SetStat(string name, float value)
		{
			return false;
		}

		public static int GetStatInt(string name)
		{
			return 0;
		}

		public static float GetStatFloat(string name)
		{
			return 0f;
		}

		public static bool ResetAll(bool includeAchievements)
		{
			return false;
		}
	}
}
