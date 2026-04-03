using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamInventory : SteamSharedClass<SteamInventory>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddPromoItemAsync_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

			public InventoryDefId id;

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
		private struct _003CCraftItemAsync_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

			public InventoryDef target;

			public InventoryItem[] list;

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
		private struct _003CCraftItemAsync_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

			public InventoryDef target;

			public InventoryItem.Amount[] list;

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
		private struct _003CDeserializeAsync_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

			public byte[] data;

			public int dataLength;

			private IntPtr _003Cptr_003E5__2;

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
		private struct _003CGenerateItemAsync_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

			public InventoryDef target;

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
		private struct _003CGetAllItemsAsync_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

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
		private struct _003CGetDefinitionsWithPricesAsync_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryDef[]> _003C_003Et__builder;

			private CallResult<SteamInventoryRequestPricesResult_t> _003C_003Eu__1;

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
		private struct _003CGrantPromoItemsAsync_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

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
		private struct _003CStartPurchaseAsync_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryPurchaseResult?> _003C_003Et__builder;

			public InventoryDef[] items;

			private CallResult<SteamInventoryStartPurchaseResult_t> _003C_003Eu__1;

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
		private struct _003CTriggerItemDropAsync_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InventoryResult?> _003C_003Et__builder;

			public InventoryDefId id;

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
		private struct _003CWaitForDefinitions_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public float timeoutSeconds;

			private Stopwatch _003Csw_003E5__2;

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

		private static Dictionary<int, InventoryDef> _defMap;

		internal static ISteamInventory Internal => null;

		public static string Currency { get; internal set; }

		public static InventoryItem[] Items { get; internal set; }

		public static InventoryDef[] Definitions { get; internal set; }

		public static event Action<InventoryResult> OnInventoryUpdated
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

		public static event Action OnDefinitionsUpdated
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

		internal static void InstallEvents(bool server)
		{
		}

		private static void InventoryUpdated(SteamInventoryFullUpdate_t x)
		{
		}

		private static void LoadDefinitions()
		{
		}

		public static void LoadItemDefinitions()
		{
		}

		[AsyncStateMachine(typeof(_003CWaitForDefinitions_003Ed__13))]
		public static Task<bool> WaitForDefinitions(float timeoutSeconds = 30f)
		{
			return null;
		}

		public static InventoryDef FindDefinition(InventoryDefId defId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetDefinitionsWithPricesAsync_003Ed__19))]
		public static Task<InventoryDef[]> GetDefinitionsWithPricesAsync()
		{
			return null;
		}

		internal static InventoryDef[] GetDefinitions()
		{
			return null;
		}

		public static bool GetAllItems()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CGetAllItemsAsync_003Ed__31))]
		public static Task<InventoryResult?> GetAllItemsAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGenerateItemAsync_003Ed__32))]
		public static Task<InventoryResult?> GenerateItemAsync(InventoryDef target, int amount)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCraftItemAsync_003Ed__33))]
		public static Task<InventoryResult?> CraftItemAsync(InventoryItem[] list, InventoryDef target)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCraftItemAsync_003Ed__34))]
		public static Task<InventoryResult?> CraftItemAsync(InventoryItem.Amount[] list, InventoryDef target)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDeserializeAsync_003Ed__35))]
		public static Task<InventoryResult?> DeserializeAsync(byte[] data, int dataLength = -1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGrantPromoItemsAsync_003Ed__36))]
		public static Task<InventoryResult?> GrantPromoItemsAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTriggerItemDropAsync_003Ed__37))]
		public static Task<InventoryResult?> TriggerItemDropAsync(InventoryDefId id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAddPromoItemAsync_003Ed__38))]
		public static Task<InventoryResult?> AddPromoItemAsync(InventoryDefId id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStartPurchaseAsync_003Ed__39))]
		public static Task<InventoryPurchaseResult?> StartPurchaseAsync(InventoryDef[] items)
		{
			return null;
		}
	}
}
