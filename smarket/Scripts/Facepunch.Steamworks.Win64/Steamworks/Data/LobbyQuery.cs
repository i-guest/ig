using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Steamworks.Data
{
	public struct LobbyQuery
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestAsync_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Lobby[]> _003C_003Et__builder;

			public LobbyQuery _003C_003E4__this;

			private CallResult<LobbyMatchList_t> _003C_003Eu__1;

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

		internal LobbyDistanceFilter? distance;

		internal Dictionary<string, string> stringFilters;

		internal List<NumericalFilter> numericalFilters;

		internal Dictionary<string, int> nearValFilters;

		internal int? slotsAvailable;

		internal int? maxResults;

		public LobbyQuery FilterDistanceClose()
		{
			return default(LobbyQuery);
		}

		public LobbyQuery FilterDistanceFar()
		{
			return default(LobbyQuery);
		}

		public LobbyQuery FilterDistanceWorldwide()
		{
			return default(LobbyQuery);
		}

		public LobbyQuery WithKeyValue(string key, string value)
		{
			return default(LobbyQuery);
		}

		public LobbyQuery WithLower(string key, int value)
		{
			return default(LobbyQuery);
		}

		public LobbyQuery WithHigher(string key, int value)
		{
			return default(LobbyQuery);
		}

		public LobbyQuery WithEqual(string key, int value)
		{
			return default(LobbyQuery);
		}

		public LobbyQuery WithNotEqual(string key, int value)
		{
			return default(LobbyQuery);
		}

		internal void AddNumericalFilter(string key, int value, LobbyComparison compare)
		{
		}

		public LobbyQuery OrderByNear(string key, int value)
		{
			return default(LobbyQuery);
		}

		public LobbyQuery WithSlotsAvailable(int minSlots)
		{
			return default(LobbyQuery);
		}

		public LobbyQuery WithMaxResults(int max)
		{
			return default(LobbyQuery);
		}

		private void ApplyFilters()
		{
		}

		[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__19))]
		public Task<Lobby[]> RequestAsync()
		{
			return null;
		}
	}
}
