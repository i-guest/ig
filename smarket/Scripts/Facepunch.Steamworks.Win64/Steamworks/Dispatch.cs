using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	public static class Dispatch
	{
		[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
		internal struct CallbackMsg_t
		{
			public HSteamUser m_hSteamUser;

			public CallbackType Type;

			public IntPtr Data;

			public int DataSize;
		}

		private struct ResultCallback
		{
			public Action continuation;

			public bool server;
		}

		private struct Callback
		{
			public Action<IntPtr> action;

			public bool server;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoopClientAsync_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

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
		private struct _003CLoopServerAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

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

		public static Action<CallbackType, string, bool> OnDebugCallback;

		public static Action<Exception> OnException;

		private static bool runningFrame;

		private static List<Action<IntPtr>> actionsToCall;

		private static Dictionary<ulong, ResultCallback> ResultCallbacks;

		private static Dictionary<CallbackType, List<Callback>> Callbacks;

		internal static HSteamPipe ClientPipe { get; set; }

		internal static HSteamPipe ServerPipe { get; set; }

		[PreserveSig]
		internal static extern void SteamAPI_ManualDispatch_Init();

		[PreserveSig]
		internal static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe pipe);

		[PreserveSig]
		internal static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe pipe, [In][Out] ref CallbackMsg_t msg);

		[PreserveSig]
		internal static extern bool SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe pipe);

		internal static void Init()
		{
		}

		internal static void Frame(HSteamPipe pipe)
		{
		}

		private static void ProcessCallback(CallbackMsg_t msg, bool isServer)
		{
		}

		internal static string CallbackToString(CallbackType type, IntPtr data, int expectedsize)
		{
			return null;
		}

		private static void ProcessResult(CallbackMsg_t msg)
		{
		}

		[AsyncStateMachine(typeof(_003CLoopClientAsync_003Ed__22))]
		internal static void LoopClientAsync()
		{
		}

		[AsyncStateMachine(typeof(_003CLoopServerAsync_003Ed__23))]
		internal static void LoopServerAsync()
		{
		}

		internal static void OnCallComplete<T>(SteamAPICall_t call, Action continuation, bool server) where T : struct, ICallbackData
		{
		}

		internal static void Install<T>(Action<T> p, bool server = false) where T : ICallbackData
		{
		}

		internal static void ShutdownServer()
		{
		}

		internal static void ShutdownClient()
		{
		}
	}
}
