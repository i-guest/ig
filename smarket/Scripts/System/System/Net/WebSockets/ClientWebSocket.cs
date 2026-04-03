using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets
{
	/// <summary>Provides a client for connecting to WebSocket services.</summary>
	public sealed class ClientWebSocket : WebSocket
	{
		private enum InternalState
		{
			Created = 0,
			Connecting = 1,
			Connected = 2,
			Disposed = 3
		}

		internal sealed class DefaultWebProxy : IWebProxy
		{
			public static DefaultWebProxy Instance { get; }

			public ICredentials Credentials => null;

			public Uri GetProxy(Uri destination)
			{
				return null;
			}

			public bool IsBypassed(Uri host)
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectAsyncCore_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ClientWebSocket _003C_003E4__this;

			public Uri uri;

			public CancellationToken cancellationToken;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

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

		private readonly ClientWebSocketOptions _options;

		private WebSocketHandle _innerWebSocket;

		private int _state;

		/// <summary>Gets the WebSocket options for the <see cref="T:System.Net.WebSockets.ClientWebSocket" /> instance.</summary>
		/// <returns>Returns <see cref="T:System.Net.WebSockets.ClientWebSocketOptions" />.The WebSocket options for the <see cref="T:System.Net.WebSockets.ClientWebSocket" /> instance.</returns>
		public ClientWebSocketOptions Options => null;

		/// <summary>Gets the reason why the close handshake was initiated on <see cref="T:System.Net.WebSockets.ClientWebSocket" /> instance.</summary>
		/// <returns>Returns <see cref="T:System.Net.WebSockets.WebSocketCloseStatus" />.The reason why the close handshake was initiated.</returns>
		public override WebSocketCloseStatus? CloseStatus => null;

		/// <summary>Gets a description of the reason why the <see cref="T:System.Net.WebSockets.ClientWebSocket" /> instance was closed.</summary>
		/// <returns>Returns <see cref="T:System.String" />.The description of the reason why the <see cref="T:System.Net.WebSockets.ClientWebSocket" /> instance was closed.</returns>
		public override string CloseStatusDescription => null;

		/// <summary>Get the WebSocket state of the <see cref="T:System.Net.WebSockets.ClientWebSocket" /> instance.</summary>
		/// <returns>Returns <see cref="T:System.Net.WebSockets.WebSocketState" />.The WebSocket state of the <see cref="T:System.Net.WebSockets.ClientWebSocket" /> instance.</returns>
		public override WebSocketState State => default(WebSocketState);

		/// <summary>Creates an instance of the <see cref="T:System.Net.WebSockets.ClientWebSocket" /> class.</summary>
		public ClientWebSocket()
		{
		}

		/// <summary>Connect to a WebSocket server as an asynchronous operation.</summary>
		/// <param name="uri">The URI of the WebSocket server to connect to.</param>
		/// <param name="cancellationToken">A cancellation token used to propagate notification that the  operation should be canceled.</param>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		public Task ConnectAsync(Uri uri, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectAsyncCore_003Ed__16))]
		private Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken)
		{
			return null;
		}

		/// <summary>Send data on <see cref="T:System.Net.WebSockets.ClientWebSocket" /> as an asynchronous operation.</summary>
		/// <param name="buffer">The buffer containing the message to be sent.</param>
		/// <param name="messageType">Specifies whether the buffer is clear text or in a binary format.</param>
		/// <param name="endOfMessage">Specifies whether this is the final asynchronous send. Set to <see langword="true" /> if this is the final send; <see langword="false" /> otherwise.</param>
		/// <param name="cancellationToken">A cancellation token used to propagate notification that this  operation should be canceled.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			return null;
		}

		/// <summary>Receive data on <see cref="T:System.Net.WebSockets.ClientWebSocket" /> as an asynchronous operation.</summary>
		/// <param name="buffer">The buffer to receive the response.</param>
		/// <param name="cancellationToken">A cancellation token used to propagate notification that this  operation should be canceled.</param>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return null;
		}

		/// <summary>Close the <see cref="T:System.Net.WebSockets.ClientWebSocket" /> instance as an asynchronous operation.</summary>
		/// <param name="closeStatus">The WebSocket close status.</param>
		/// <param name="statusDescription">A description of the close status.</param>
		/// <param name="cancellationToken">A cancellation token used to propagate notification that this  operation should be canceled.</param>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return null;
		}

		/// <summary>Close the output for the <see cref="T:System.Net.WebSockets.ClientWebSocket" /> instance as an asynchronous operation.</summary>
		/// <param name="closeStatus">The WebSocket close status.</param>
		/// <param name="statusDescription">A description of the close status.</param>
		/// <param name="cancellationToken">A cancellation token used to propagate notification that this  operation should be canceled.</param>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return null;
		}

		/// <summary>Aborts the connection and cancels any pending IO operations.</summary>
		public override void Abort()
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.WebSockets.ClientWebSocket" /> instance.</summary>
		public override void Dispose()
		{
		}

		private void ThrowIfNotConnected()
		{
		}
	}
}
