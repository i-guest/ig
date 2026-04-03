using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Steamworks.Data;
using Steamworks.Ugc;

namespace Steamworks
{
	public class SteamUGC : SteamSharedClass<SteamUGC>
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			public bool downloadStarted;

			internal void _003CDownloadAsync_003Eb__0(Result r)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteFileAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public PublishedFileId fileId;

			private CallResult<DeleteItemResult_t> _003C_003Eu__1;

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
		private struct _003CDownloadAsync_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public PublishedFileId fileId;

			public CancellationToken ct;

			public Action<float> progress;

			public int milisecondsUpdateDelay;

			private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

			private Item _003Citem_003E5__2;

			private Action<Result> _003ConDownloadStarted_003E5__3;

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
		private struct _003CGetWorkshopEulaStatus_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool?> _003C_003Et__builder;

			private CallResult<WorkshopEULAStatus_t> _003C_003Eu__1;

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
		private struct _003CQueryFileAsync_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Item?> _003C_003Et__builder;

			public PublishedFileId fileId;

			private TaskAwaiter<ResultPage?> _003C_003Eu__1;

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
		private struct _003CStartPlaytimeTracking_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public PublishedFileId fileId;

			private CallResult<StartPlaytimeTrackingResult_t> _003C_003Eu__1;

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
		private struct _003CStopPlaytimeTracking_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public PublishedFileId fileId;

			private CallResult<StopPlaytimeTrackingResult_t> _003C_003Eu__1;

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
		private struct _003CStopPlaytimeTrackingForAllItems_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			private CallResult<StopPlaytimeTrackingResult_t> _003C_003Eu__1;

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

		internal static ISteamUGC Internal => null;

		public static event Action<Result> OnDownloadItemResult
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

		public static event Action<AppId, PublishedFileId> OnItemSubscribed
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

		public static event Action<AppId, PublishedFileId> OnItemUnsubscribed
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

		public static event Action<AppId, PublishedFileId> OnItemInstalled
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

		[AsyncStateMachine(typeof(_003CDeleteFileAsync_003Ed__16))]
		public static Task<bool> DeleteFileAsync(PublishedFileId fileId)
		{
			return null;
		}

		public static bool Download(PublishedFileId fileId, bool highPriority = false)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CDownloadAsync_003Ed__18))]
		public static Task<bool> DownloadAsync(PublishedFileId fileId, Action<float> progress = null, int milisecondsUpdateDelay = 60, CancellationToken ct = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CQueryFileAsync_003Ed__19))]
		public static Task<Item?> QueryFileAsync(PublishedFileId fileId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStartPlaytimeTracking_003Ed__20))]
		public static Task<bool> StartPlaytimeTracking(PublishedFileId fileId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStopPlaytimeTracking_003Ed__21))]
		public static Task<bool> StopPlaytimeTracking(PublishedFileId fileId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStopPlaytimeTrackingForAllItems_003Ed__22))]
		public static Task<bool> StopPlaytimeTrackingForAllItems()
		{
			return null;
		}

		public static void SuspendDownloads()
		{
		}

		public static void ResumeDownloads()
		{
		}

		public static bool ShowWorkshopEula()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CGetWorkshopEulaStatus_003Ed__26))]
		public static Task<bool?> GetWorkshopEulaStatus()
		{
			return null;
		}
	}
}
