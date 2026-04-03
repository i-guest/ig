using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets
{
	internal sealed class WebSocketHandle
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectAsyncCore_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public WebSocketHandle _003C_003E4__this;

			public Uri uri;

			public ClientWebSocketOptions options;

			private CancellationTokenRegistration _003Cregistration_003E5__2;

			private Stream _003Cstream_003E5__3;

			private KeyValuePair<string, string> _003CsecKeyAndSecWebSocketAccept_003E5__4;

			private ConfiguredTaskAwaitable<Socket>.ConfiguredTaskAwaiter _003C_003Eu__1;

			private SslStream _003CsslStream_003E5__5;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__3;

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
		private struct _003CConnectSocketAsync_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Socket> _003C_003Et__builder;

			public string host;

			public CancellationToken cancellationToken;

			public WebSocketHandle _003C_003E4__this;

			public int port;

			private ConfiguredTaskAwaitable<IPAddress[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

			private IPAddress[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private Socket _003Csocket_003E5__4;

			private CancellationTokenRegistration _003C_003E7__wrap4;

			private CancellationTokenRegistration _003C_003E7__wrap5;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

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
		private struct _003CParseAndValidateConnectResponseAsync_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public Stream stream;

			public CancellationToken cancellationToken;

			public string expectedSecWebSocketAccept;

			public ClientWebSocketOptions options;

			private bool _003CfoundUpgrade_003E5__2;

			private bool _003CfoundConnection_003E5__3;

			private bool _003CfoundSecWebSocketAccept_003E5__4;

			private string _003Csubprotocol_003E5__5;

			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
		private struct _003CReadResponseHeaderLineAsync_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public Stream stream;

			public CancellationToken cancellationToken;

			private StringBuilder _003Csb_003E5__2;

			private byte[] _003Carr_003E5__3;

			private char _003CprevChar_003E5__4;

			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

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

		[ThreadStatic]
		private static StringBuilder t_cachedStringBuilder;

		private static readonly Encoding s_defaultHttpEncoding;

		private readonly CancellationTokenSource _abortSource;

		private WebSocketState _state;

		private WebSocket _webSocket;

		public WebSocketCloseStatus? CloseStatus => null;

		public string CloseStatusDescription => null;

		public WebSocketState State => default(WebSocketState);

		public static WebSocketHandle Create()
		{
			return null;
		}

		public static bool IsValid(WebSocketHandle handle)
		{
			return false;
		}

		public static void CheckPlatformSupport()
		{
		}

		public void Dispose()
		{
		}

		public void Abort()
		{
		}

		public Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectAsyncCore_003Ed__26))]
		public Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken, ClientWebSocketOptions options)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectSocketAsync_003Ed__27))]
		private Task<Socket> ConnectSocketAsync(string host, int port, CancellationToken cancellationToken)
		{
			return null;
		}

		private static byte[] BuildRequestHeader(Uri uri, ClientWebSocketOptions options, string secKey)
		{
			return null;
		}

		private static KeyValuePair<string, string> CreateSecKeyAndSecWebSocketAccept()
		{
			return default(KeyValuePair<string, string>);
		}

		[AsyncStateMachine(typeof(_003CParseAndValidateConnectResponseAsync_003Ed__30))]
		private Task<string> ParseAndValidateConnectResponseAsync(Stream stream, ClientWebSocketOptions options, string expectedSecWebSocketAccept, CancellationToken cancellationToken)
		{
			return null;
		}

		private static void ValidateAndTrackHeader(string targetHeaderName, string targetHeaderValue, string foundHeaderName, string foundHeaderValue, ref bool foundHeader)
		{
		}

		[AsyncStateMachine(typeof(_003CReadResponseHeaderLineAsync_003Ed__32))]
		private static Task<string> ReadResponseHeaderLineAsync(Stream stream, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
