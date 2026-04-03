using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamServerStats : SteamServerClass<SteamServerStats>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestUserStatsAsync_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Result> _003C_003Et__builder;

			public SteamId steamid;

			private CallResult<GSStatsReceived_t> _003C_003Eu__1;

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
		private struct _003CStoreUserStats_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Result> _003C_003Et__builder;

			public SteamId steamid;

			private CallResult<GSStatsStored_t> _003C_003Eu__1;

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

		internal static ISteamGameServerStats Internal => null;

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CRequestUserStatsAsync_003Ed__3))]
		public static Task<Result> RequestUserStatsAsync(SteamId steamid)
		{
			return null;
		}

		public static bool SetInt(SteamId steamid, string name, int stat)
		{
			return false;
		}

		public static bool SetFloat(SteamId steamid, string name, float stat)
		{
			return false;
		}

		public static int GetInt(SteamId steamid, string name, int defaultValue = 0)
		{
			return 0;
		}

		public static float GetFloat(SteamId steamid, string name, float defaultValue = 0f)
		{
			return 0f;
		}

		public static bool SetAchievement(SteamId steamid, string name)
		{
			return false;
		}

		public static bool ClearAchievement(SteamId steamid, string name)
		{
			return false;
		}

		public static bool GetAchievement(SteamId steamid, string name)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CStoreUserStats_003Ed__11))]
		public static Task<Result> StoreUserStats(SteamId steamid)
		{
			return null;
		}
	}
}
