using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamUser : SteamClientClass<SteamUser>
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass57_0
		{
			public AuthTicket ticket;

			public Result result;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass59_0
		{
			public AuthTicket ticket;

			public Result result;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAuthSessionTicketAsync_003Ed__57 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AuthTicket> _003C_003Et__builder;

			public NetIdentity identity;

			public double timeoutSeconds;

			private _003C_003Ec__DisplayClass57_0 _003C_003E8__1;

			private Stopwatch _003Cstopwatch_003E5__2;

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
		private struct _003CGetAuthTicketForWebApiAsync_003Ed__59 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AuthTicket> _003C_003Et__builder;

			public string identity;

			public double timeoutSeconds;

			private _003C_003Ec__DisplayClass59_0 _003C_003E8__1;

			private Stopwatch _003Cstopwatch_003E5__2;

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
		private struct _003CGetDurationControl_003Ed__77 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<DurationControl> _003C_003Et__builder;

			private CallResult<DurationControl_t> _003C_003Eu__1;

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
		private struct _003CGetStoreAuthUrlAsync_003Ed__66 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public string url;

			private CallResult<StoreAuthURLResponse_t> _003C_003Eu__1;

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
		private struct _003CRequestEncryptedAppTicketAsync_003Ed__75 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

			public byte[] dataToInclude;

			private IntPtr _003CdataPtr_003E5__2;

			private CallResult<EncryptedAppTicketResponse_t> _003C_003Eu__1;

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
		private struct _003CRequestEncryptedAppTicketAsync_003Ed__76 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

			private CallResult<EncryptedAppTicketResponse_t> _003C_003Eu__1;

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

		private static Dictionary<string, string> richPresence;

		private static bool _recordingVoice;

		private static byte[] readBuffer;

		private static uint sampleRate;

		internal static ISteamUser Internal => null;

		public static bool VoiceRecord
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool HasVoiceData => false;

		public static uint SampleRate
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public static uint OptimalSampleRate => 0u;

		public static bool IsBehindNAT => false;

		public static int SteamLevel => 0;

		public static bool IsPhoneVerified => false;

		public static bool IsTwoFactorEnabled => false;

		public static bool IsPhoneIdentifying => false;

		public static bool IsPhoneRequiringVerification => false;

		public static event Action OnSteamServersConnected
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

		public static event Action OnSteamServerConnectFailure
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

		public static event Action OnSteamServersDisconnected
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

		public static event Action OnClientGameServerDeny
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

		public static event Action OnLicensesUpdated
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

		public static event Action<SteamId, SteamId, AuthResponse> OnValidateAuthTicketResponse
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

		internal static event Action<GetAuthSessionTicketResponse_t> OnGetAuthSessionTicketResponse
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

		internal static event Action<GetTicketForWebApiResponse_t> OnGetTicketForWebApiResponse
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

		public static event Action<AppId, ulong, bool> OnMicroTxnAuthorizationResponse
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

		public static event Action<string> OnGameWebCallback
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

		public static event Action<DurationControl> OnDurationControl
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

		public static int ReadVoiceData(Stream stream)
		{
			return 0;
		}

		public static byte[] ReadVoiceDataBytes()
		{
			return null;
		}

		public static int DecompressVoice(Stream input, int length, Stream output)
		{
			return 0;
		}

		public static int DecompressVoice(byte[] from, Stream output)
		{
			return 0;
		}

		public static int DecompressVoice(IntPtr from, int length, IntPtr to, int bufferSize)
		{
			return 0;
		}

		public static AuthTicket GetAuthSessionTicket(NetIdentity identity)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetAuthSessionTicketAsync_003Ed__57))]
		public static Task<AuthTicket> GetAuthSessionTicketAsync(NetIdentity identity, double timeoutSeconds = 10.0)
		{
			return null;
		}

		private static AuthTicket GetAuthTicketForWebApi(string identity)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetAuthTicketForWebApiAsync_003Ed__59))]
		public static Task<AuthTicket> GetAuthTicketForWebApiAsync(string identity, double timeoutSeconds = 10.0)
		{
			return null;
		}

		public static BeginAuthResult BeginAuthSession(byte[] ticketData, SteamId steamid)
		{
			return default(BeginAuthResult);
		}

		public static void EndAuthSession(SteamId steamid)
		{
		}

		[AsyncStateMachine(typeof(_003CGetStoreAuthUrlAsync_003Ed__66))]
		public static Task<string> GetStoreAuthUrlAsync(string url)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestEncryptedAppTicketAsync_003Ed__75))]
		public static Task<byte[]> RequestEncryptedAppTicketAsync(byte[] dataToInclude)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestEncryptedAppTicketAsync_003Ed__76))]
		public static Task<byte[]> RequestEncryptedAppTicketAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetDurationControl_003Ed__77))]
		public static Task<DurationControl> GetDurationControl()
		{
			return null;
		}
	}
}
