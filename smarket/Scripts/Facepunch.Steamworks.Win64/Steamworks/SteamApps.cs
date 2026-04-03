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
	public class SteamApps : SteamSharedClass<SteamApps>
	{
		[CompilerGenerated]
		private sealed class _003CDlcInformation_003Ed__29 : IEnumerable<DlcInformation>, IEnumerable, IEnumerator<DlcInformation>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private DlcInformation _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private AppId _003Cappid_003E5__2;

			private bool _003Cavailable_003E5__3;

			private int _003Ci_003E5__4;

			DlcInformation IEnumerator<DlcInformation>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(DlcInformation);
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
			public _003CDlcInformation_003Ed__29(int _003C_003E1__state)
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
			IEnumerator<DlcInformation> IEnumerable<DlcInformation>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetFileDetailsAsync_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<FileDetails?> _003C_003Et__builder;

			public string filename;

			private CallResult<FileDetailsResult_t> _003C_003Eu__1;

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
		private sealed class _003CInstalledDepots_003Ed__35 : IEnumerable<DepotId>, IEnumerable, IEnumerator<DepotId>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private DepotId _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private AppId appid;

			public AppId _003C_003E3__appid;

			private DepotId_t[] _003Cdepots_003E5__2;

			private uint _003Ccount_003E5__3;

			private int _003Ci_003E5__4;

			DepotId IEnumerator<DepotId>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(DepotId);
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
			public _003CInstalledDepots_003Ed__35(int _003C_003E1__state)
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
			IEnumerator<DepotId> IEnumerable<DepotId>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal static ISteamApps Internal => null;

		public static bool IsSubscribed => false;

		public static bool IsSubscribedFromFamilySharing => false;

		public static bool IsLowViolence => false;

		public static bool IsCybercafe => false;

		public static bool IsVACBanned => false;

		public static string GameLanguage => null;

		public static string[] AvailableLanguages => null;

		public static bool IsSubscribedFromFreeWeekend => false;

		public static string CurrentBetaName => null;

		public static SteamId AppOwner => default(SteamId);

		public static int BuildId => 0;

		public static string CommandLine => null;

		public static event Action<AppId> OnDlcInstalled
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

		public static event Action OnNewLaunchParameters
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

		public static bool IsSubscribedToApp(AppId appid)
		{
			return false;
		}

		public static bool IsDlcInstalled(AppId appid)
		{
			return false;
		}

		public static DateTime PurchaseTime(AppId appid = default(AppId))
		{
			return default(DateTime);
		}

		[IteratorStateMachine(typeof(_003CDlcInformation_003Ed__29))]
		public static IEnumerable<DlcInformation> DlcInformation()
		{
			return null;
		}

		public static void InstallDlc(AppId appid)
		{
		}

		public static void UninstallDlc(AppId appid)
		{
		}

		public static void MarkContentCorrupt(bool missingFilesOnly)
		{
		}

		[IteratorStateMachine(typeof(_003CInstalledDepots_003Ed__35))]
		public static IEnumerable<DepotId> InstalledDepots(AppId appid = default(AppId))
		{
			return null;
		}

		public static string AppInstallDir(AppId appid = default(AppId))
		{
			return null;
		}

		public static bool IsAppInstalled(AppId appid)
		{
			return false;
		}

		public static string GetLaunchParam(string param)
		{
			return null;
		}

		public static DownloadProgress DlcDownloadProgress(AppId appid)
		{
			return default(DownloadProgress);
		}

		[AsyncStateMachine(typeof(_003CGetFileDetailsAsync_003Ed__44))]
		public static Task<FileDetails?> GetFileDetailsAsync(string filename)
		{
			return null;
		}

		public static bool IsTimedTrial(out int secondsAllowed, out int secondsPlayed)
		{
			secondsAllowed = default(int);
			secondsPlayed = default(int);
			return false;
		}
	}
}
