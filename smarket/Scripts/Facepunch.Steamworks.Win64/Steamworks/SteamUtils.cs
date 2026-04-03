using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamUtils : SteamSharedClass<SteamUtils>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckFileSignatureAsync_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CheckFileSignature> _003C_003Et__builder;

			public string filename;

			private CallResult<CheckFileSignature_t> _003C_003Eu__1;

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

		private static NotificationPosition overlayNotificationPosition;

		internal static ISteamUtils Internal => null;

		public static uint SecondsSinceAppActive => 0u;

		public static uint SecondsSinceComputerActive => 0u;

		public static Universe ConnectedUniverse => default(Universe);

		public static DateTime SteamServerTime => default(DateTime);

		public static string IpCountry => null;

		public static bool UsingBatteryPower => false;

		public static float CurrentBatteryPower => 0f;

		public static NotificationPosition OverlayNotificationPosition
		{
			get
			{
				return default(NotificationPosition);
			}
			set
			{
			}
		}

		public static bool IsOverlayEnabled => false;

		public static bool DoesOverlayNeedPresent => false;

		public static string SteamUILanguage => null;

		public static bool IsSteamRunningInVR => false;

		public static bool IsSteamInBigPictureMode => false;

		public static bool VrHeadsetStreaming
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool IsSteamChinaLauncher => false;

		public static bool IsRunningOnSteamDeck => false;

		public static event Action OnIpCountryChanged
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

		public static event Action<int> OnLowBatteryPower
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

		public static event Action OnSteamShutdown
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

		public static event Action<bool> OnGamepadTextInputDismissed
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

		private static void SteamClosed()
		{
		}

		public static bool GetImageSize(int image, out uint width, out uint height)
		{
			width = default(uint);
			height = default(uint);
			return false;
		}

		public static Image? GetImage(int image)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCheckFileSignatureAsync_003Ed__41))]
		public static Task<CheckFileSignature> CheckFileSignatureAsync(string filename)
		{
			return null;
		}

		public static bool ShowGamepadTextInput(GamepadTextInputMode inputMode, GamepadTextInputLineMode lineInputMode, string description, int maxChars, string existingText = "")
		{
			return false;
		}

		public static string GetEnteredGamepadText()
		{
			return null;
		}

		public static void SetOverlayNotificationInset(int x, int y)
		{
		}

		public static void StartVRDashboard()
		{
		}

		internal static bool IsCallComplete(SteamAPICall_t call, out bool failed)
		{
			failed = default(bool);
			return false;
		}

		public static bool InitFilterText()
		{
			return false;
		}

		public static string FilterText(TextFilteringContext context, SteamId sourceSteamID, string inputMessage)
		{
			return null;
		}

		public static void SetGameLauncherMode(bool mode)
		{
		}
	}
}
