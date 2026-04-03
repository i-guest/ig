using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	internal static class SourceServerQuery
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetChallengeData_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

			public UdpClient client;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<byte[]> _003C_003Eu__2;

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
		private struct _003CGetRules_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Dictionary<string, string>> _003C_003Et__builder;

			public UdpClient client;

			private TaskAwaiter<byte[]> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CGetRulesImpl_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Dictionary<string, string>> _003C_003Et__builder;

			public IPEndPoint endpoint;

			private UdpClient _003Cclient_003E5__2;

			private TaskAwaiter<Dictionary<string, string>> _003C_003Eu__1;

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
		private struct _003CReceive_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

			public UdpClient client;

			private byte[][] _003Cpackets_003E5__2;

			private TaskAwaiter<UdpReceiveResult> _003C_003Eu__1;

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
		private struct _003CSend_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public byte[] message;

			public UdpClient client;

			private TaskAwaiter<int> _003C_003Eu__1;

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

		private static readonly byte[] A2S_SERVERQUERY_GETCHALLENGE;

		private const byte A2S_RULES = 86;

		private static readonly Dictionary<IPEndPoint, Task<Dictionary<string, string>>> PendingQueries;

		internal static Task<Dictionary<string, string>> GetRules(ServerInfo server)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetRulesImpl_003Ed__4))]
		private static Task<Dictionary<string, string>> GetRulesImpl(IPEndPoint endpoint)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetRules_003Ed__5))]
		private static Task<Dictionary<string, string>> GetRules(UdpClient client)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReceive_003Ed__6))]
		private static Task<byte[]> Receive(UdpClient client)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetChallengeData_003Ed__7))]
		private static Task<byte[]> GetChallengeData(UdpClient client)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSend_003Ed__8))]
		private static Task Send(UdpClient client, byte[] message)
		{
			return null;
		}

		private static byte[] Combine(byte[][] arrays)
		{
			return null;
		}
	}
}
