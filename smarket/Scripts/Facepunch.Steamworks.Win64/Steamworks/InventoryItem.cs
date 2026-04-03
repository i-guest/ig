using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public struct InventoryItem : IEquatable<InventoryItem>
	{
		public struct Amount
		{
			public InventoryItem Item;

			public int Quantity;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

			public InventoryItem add;

			public int quantity;

			public InventoryItem _003C_003E4__this;

			private TaskAwaiter<InventoryResult?> _003C_003Eu__1;

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
		private struct _003CConsumeAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

			public InventoryItem _003C_003E4__this;

			public int amount;

			private TaskAwaiter<InventoryResult?> _003C_003Eu__1;

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
		private struct _003CSplitStackAsync_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

			public InventoryItem _003C_003E4__this;

			public int quantity;

			private TaskAwaiter<InventoryResult?> _003C_003Eu__1;

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

		internal InventoryItemId _id;

		internal InventoryDefId _def;

		internal SteamItemFlags _flags;

		internal ushort _quantity;

		internal Dictionary<string, string> _properties;

		public InventoryItemId Id => default(InventoryItemId);

		public InventoryDefId DefId => default(InventoryDefId);

		public int Quantity => 0;

		public InventoryDef Def => null;

		public Dictionary<string, string> Properties => null;

		public bool IsNoTrade => false;

		public bool IsRemoved => false;

		public bool IsConsumed => false;

		public DateTime Acquired => default(DateTime);

		public string Origin => null;

		[AsyncStateMachine(typeof(_003CConsumeAsync_003Ed__21))]
		public Task<InventoryResult?> ConsumeAsync(int amount = 1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSplitStackAsync_003Ed__22))]
		public Task<InventoryResult?> SplitStackAsync(int quantity = 1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAddAsync_003Ed__23))]
		public Task<InventoryResult?> AddAsync(InventoryItem add, int quantity = 1)
		{
			return null;
		}

		internal static InventoryItem From(SteamItemDetails_t details)
		{
			return default(InventoryItem);
		}

		internal static Dictionary<string, string> GetProperties(SteamInventoryResult_t result, int index)
		{
			return null;
		}

		public static bool operator ==(InventoryItem a, InventoryItem b)
		{
			return false;
		}

		public static bool operator !=(InventoryItem a, InventoryItem b)
		{
			return false;
		}

		public override bool Equals(object p)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(InventoryItem p)
		{
			return false;
		}
	}
}
