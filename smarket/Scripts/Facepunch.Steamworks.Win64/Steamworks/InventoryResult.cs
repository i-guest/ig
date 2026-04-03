using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public struct InventoryResult : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

			public SteamInventoryResult_t sresult;

			private Result _003C_result_003E5__2;

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

		internal SteamInventoryResult_t _id;

		public bool Expired { get; internal set; }

		public int ItemCount => 0;

		internal InventoryResult(SteamInventoryResult_t id, bool expired)
		{
			_id = default(SteamInventoryResult_t);
			Expired = false;
		}

		public bool BelongsTo(SteamId steamId)
		{
			return false;
		}

		public InventoryItem[] GetItems(bool includeProperties = false)
		{
			return null;
		}

		public void Dispose()
		{
		}

		[AsyncStateMachine(typeof(_003CGetAsync_003Ed__11))]
		internal static Task<InventoryResult?> GetAsync(SteamInventoryResult_t sresult)
		{
			return null;
		}

		public byte[] Serialize()
		{
			return null;
		}
	}
}
