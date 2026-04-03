using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamNetworkingUtils : SteamSharedClass<SteamNetworkingUtils>
	{
		private struct DebugMessage
		{
			public NetDebugOutput Type;

			public string Msg;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWaitForPingDataAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public float maxAgeInSeconds;

			private SteamRelayNetworkStatus_t _003Cstatus_003E5__2;

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

		private static NetDebugOutput _debugLevel;

		private static NetDebugFunc _debugFunc;

		private static ConcurrentQueue<DebugMessage> debugMessages;

		internal static ISteamNetworkingUtils Internal => null;

		public static SteamNetworkingAvailability Status { get; private set; }

		public static NetPingLocation? LocalPingLocation => null;

		public static long LocalTimestamp => 0L;

		public static float FakeSendPacketLoss
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float FakeRecvPacketLoss
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float FakeSendPacketLag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float FakeRecvPacketLag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static int ConnectionTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int Timeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int SendBufferSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int SendRateMin
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int SendRateMax
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int NagleTime
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int AllowWithoutAuth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int Unencrypted
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int DebugLevelAckRTT
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int DebugLevelPacketDecode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int DebugLevelMessage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int DebugLevelPacketGaps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int DebugLevelP2PRendezvous
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int DebugLevelSDRRelayPings
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static NetDebugOutput DebugLevel
		{
			get
			{
				return default(NetDebugOutput);
			}
			set
			{
			}
		}

		public static event Action<NetDebugOutput, string> OnDebugOutput
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

		private static void InstallCallbacks(bool server)
		{
		}

		public static void InitRelayNetworkAccess()
		{
		}

		public static int EstimatePingTo(NetPingLocation target)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CWaitForPingDataAsync_003Ed__15))]
		public static Task WaitForPingDataAsync(float maxAgeInSeconds = 300f)
		{
			return null;
		}

		[MonoPInvokeCallback]
		private static void OnDebugMessage(NetDebugOutput nType, IntPtr str)
		{
		}

		internal static void LogDebugMessage(NetDebugOutput type, string message)
		{
		}

		internal static void OutputDebugMessages()
		{
		}

		internal unsafe static NetMsg* AllocateMessage()
		{
			return null;
		}

		internal static bool SetConfigInt(NetConfig type, int value)
		{
			return false;
		}

		internal static int GetConfigInt(NetConfig type)
		{
			return 0;
		}

		internal static bool SetConfigFloat(NetConfig type, float value)
		{
			return false;
		}

		internal static float GetConfigFloat(NetConfig type)
		{
			return 0f;
		}

		internal static bool SetConfigString(NetConfig type, string value)
		{
			return false;
		}
	}
}
