using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Steamworks.Data
{
	public struct Stat
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetGlobalFloatDays_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<double[]> _003C_003Et__builder;

			public int days;

			public Stat _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetGlobalIntDaysAsync_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<long[]> _003C_003Et__builder;

			public int days;

			public Stat _003C_003E4__this;

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

		public string Name { get; internal set; }

		public SteamId UserId { get; internal set; }

		public Stat(string name)
		{
			Name = null;
			UserId = default(SteamId);
		}

		public Stat(string name, SteamId user)
		{
			Name = null;
			UserId = default(SteamId);
		}

		internal void LocalUserOnly([CallerMemberName] string caller = null)
		{
		}

		public double GetGlobalFloat()
		{
			return 0.0;
		}

		public long GetGlobalInt()
		{
			return 0L;
		}

		[AsyncStateMachine(typeof(_003CGetGlobalIntDaysAsync_003Ed__13))]
		public Task<long[]> GetGlobalIntDaysAsync(int days)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetGlobalFloatDays_003Ed__14))]
		public Task<double[]> GetGlobalFloatDays(int days)
		{
			return null;
		}

		public float GetFloat()
		{
			return 0f;
		}

		public int GetInt()
		{
			return 0;
		}

		public bool Set(int val)
		{
			return false;
		}

		public bool Set(float val)
		{
			return false;
		}

		public bool Add(int val)
		{
			return false;
		}

		public bool Add(float val)
		{
			return false;
		}

		public bool UpdateAverageRate(float count, float sessionlength)
		{
			return false;
		}

		public bool Store()
		{
			return false;
		}
	}
}
