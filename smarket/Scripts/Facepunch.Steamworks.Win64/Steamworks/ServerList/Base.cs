using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks.ServerList
{
	public abstract class Base : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunQueryAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Base _003C_003E4__this;

			public float timeoutSeconds;

			private Stopwatch _003Cstopwatch_003E5__2;

			private HServerListRequest _003CthisRequest_003E5__3;

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

		public List<ServerInfo> Responsive;

		public List<ServerInfo> Unresponsive;

		public List<ServerInfo> Unqueried;

		internal HServerListRequest request;

		internal List<MatchMakingKeyValuePair> filters;

		internal List<int> watchList;

		internal int LastCount;

		internal static ISteamMatchmakingServers Internal => null;

		public AppId AppId { get; set; }

		internal int Count => 0;

		internal bool IsRefreshing => false;

		public event Action OnChanges
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

		public event Action<ServerInfo> OnResponsiveServer
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

		public Base()
		{
		}

		[AsyncStateMachine(typeof(_003CRunQueryAsync_003Ed__16))]
		public virtual Task<bool> RunQueryAsync(float timeoutSeconds = 10f)
		{
			return null;
		}

		public virtual void Cancel()
		{
		}

		internal abstract void LaunchQuery();

		internal virtual MatchMakingKeyValuePair[] GetFilters()
		{
			return null;
		}

		public void AddFilter(string key, string value)
		{
		}

		private void Reset()
		{
		}

		private void ReleaseQuery()
		{
		}

		public virtual void Dispose()
		{
		}

		internal void InvokeChanges()
		{
		}

		private void UpdatePending()
		{
		}

		public void UpdateResponsive()
		{
		}

		private void MovePendingToUnresponsive()
		{
		}

		private void OnServer(ServerInfo serverInfo, bool responded)
		{
		}
	}
}
